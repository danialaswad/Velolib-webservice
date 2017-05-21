using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Device.Location;
using System.Globalization;

namespace ServiceWCF
{
    public class ItineraryService : IItineraryService
    {
        public string getItinerary(string origin, string destination)
        {
            string walk = "";
            string cycle = "";
            string velibAddress = getClosestVelib(origin);
            walk += getMapsDirections(origin, velibAddress, "walking");
            cycle += getMapsDirections(velibAddress, destination, "bicycling");

            dynamic jsonWalk = JsonConvert.DeserializeObject(walk);
            dynamic jsonCycle = JsonConvert.DeserializeObject(cycle);

            JObject jWalk = new JObject();
            jWalk.Add("start", jsonWalk.routes[0].legs[0].start_address);
            jWalk.Add("end", velibAddress);
            jWalk.Add("distance", jsonWalk.routes[0].legs[0].distance);
            jWalk.Add("duration", jsonWalk.routes[0].legs[0].duration);
            jWalk.Add("steps", jsonWalk.routes[0].legs[0].steps);

        
            JObject jCycle = new JObject();
            jCycle.Add("start", velibAddress);
            jCycle.Add("end", jsonCycle.routes[0].legs[0].end_address);
            jCycle.Add("distance", jsonCycle.routes[0].legs[0].distance);
            jCycle.Add("duration", jsonCycle.routes[0].legs[0].duration);
            jCycle.Add("steps", jsonCycle.routes[0].legs[0].steps);

            JObject res = new JObject();

            res.Add("start", jsonWalk.routes[0].legs[0].start_address);
            res.Add("end", jsonCycle.routes[0].legs[0].end_address);
            res.Add("distance", getTotalDistance(jsonWalk, jsonCycle));
            res.Add("duration", getTotalDuration(jsonWalk, jsonCycle));
            res.Add("walk", jWalk);
            res.Add("cycle", jCycle);
            return res.ToString();
           
            //return string.Format("You entered: {0}", value);
        }

        static JObject getTotalDuration(dynamic json1, dynamic json2)
        {

            int durationWalk = json1.routes[0].legs[0].duration.value;
            int durationCycle = json2.routes[0].legs[0].duration.value;

            int hour = (durationCycle + durationWalk) / 3600;
            int min = ((durationCycle + durationWalk) / 60) - (hour * 60);

            JObject json = new JObject();

            json.Add("text", hour + " hour(s) " + min + " min(s)");
            json.Add("value", durationCycle + durationWalk);

            return json;
        }

        static JObject getTotalDistance(dynamic json1, dynamic json2)
        {
            int distanceWalk = json1.routes[0].legs[0].distance.value;
            int distanceCycle = json2.routes[0].legs[0].distance.value;

            string distanceValue = (distanceCycle + distanceWalk).ToString();

            string distanceText = (((float)distanceCycle + (float)distanceWalk) / 1000).ToString();

            distanceText = distanceText.Substring(0, distanceText.Length - 2) + " km";

            JObject json = new JObject();

            json.Add("text", distanceText);
            json.Add("value", distanceValue);

            return json;
        }
        
        //Obtention d'itinéraire entre deux addresses selon un mode de déplacement avec l'API GMaps 
        public static string getMapsDirections(string origin, string destination, string mode)
        {
            string apiKey = "AIzaSyA-1i10h9yGuytFsM8uQN9kzfq-NaYVsHU";
            destination = destination.Replace(' ', '+');
            origin = origin.Replace(' ', '+');
            WebRequest request = WebRequest.Create("https://maps.googleapis.com/maps/api/directions/json?origin="+origin+"&destination=" + destination + "&mode="+mode + "&key=" + apiKey);

            // Get Response from the Service 
            WebResponse response = request.GetResponse();

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access and put it into a string
            StreamReader reader = new StreamReader(dataStream); // Read the content.
            string responseFromServer = reader.ReadToEnd(); // Put it in a String 
            reader.Close();
            response.Close();
            return responseFromServer;
        }




        //Calcul la distance entre des coordonnees d'origine et des coordonnees de velib
        static double getDistance(GeoCoordinate originCoord, string velibLongStr, string velibLatStr)
        {
            //On cree des coordonnées à partir de la long et lat du velib
            double velibLat = 0;
            double velibLong = 0;
            velibLong=double.Parse(velibLongStr, CultureInfo.InvariantCulture);
            velibLat=double.Parse(velibLatStr, CultureInfo.InvariantCulture);

            GeoCoordinate velibCoord = new GeoCoordinate(velibLat, velibLong);

            return originCoord.GetDistanceTo(velibCoord);

        }

        //Fonction qui donne des coordonnees (latitude et longitude) a partir d'une addresse
        static GeoCoordinate getAddressCoordinate(string origin)
        {
            //Tout d'abord on récupère la latitude et longitude de l'addresse d'origine
            string apiKey = "AIzaSyA6o9xPIDlOd8oAjTMyrwO2SpkHbUGtPX0";
            //On utilise l'API geocoding
            WebRequest request = WebRequest.Create("https://maps.googleapis.com/maps/api/geocode/xml?address=" + origin + "&key=" + apiKey);
            // Get Response from the Service 
            WebResponse response = request.GetResponse();

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access and put it into a string
            StreamReader reader = new StreamReader(dataStream); // Read the content.
            string responseFromServer = reader.ReadToEnd(); // Put it in a String 

            // Parse the response and put the entries in XmlNodeList 
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(responseFromServer);
            XmlNodeList elemList = doc.GetElementsByTagName("location");
            double originLat = 0;
            double originLong = 0;
            originLong=double.Parse(elemList[0].SelectSingleNode("lng").InnerText, CultureInfo.InvariantCulture);
            originLat=double.Parse(elemList[0].SelectSingleNode("lat").InnerText, CultureInfo.InvariantCulture);
            GeoCoordinate originCoord = new GeoCoordinate(originLat, originLong);

            return originCoord;
        }

        

        //Fonction qui trouve le vélib le plus proche de l'adresse origin
        static String getClosestVelib(string origin)
        {
            double shortestDistance = -1;
            string velibAddress = "";

            //Coordonnées de l'addresse de départ
            GeoCoordinate originCoord = getAddressCoordinate(origin);
            

            // Create a request for the URL.
            WebRequest request = WebRequest.Create("http://www.velib.paris/service/carto");


            // Get Response from the Service 
            WebResponse response = request.GetResponse();

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access and put it into a string
            StreamReader reader = new StreamReader(dataStream); // Read the content.
            string responseFromServer = reader.ReadToEnd(); // Put it in a String 

            // Parse the response and put the entries in XmlNodeList 
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(responseFromServer);
            XmlNodeList elemList = doc.GetElementsByTagName("marker");

            // browse the XmlNodeList
            for (int i = 0; i < elemList.Count; i++)
            {
                try
                {
                
                    //On calcule la distance avec les velibs pour trouver le velib le plus proche
                    try
                    {
                        double newDistance = getDistance(originCoord, elemList[i].Attributes["lng"].Value, elemList[i].Attributes["lat"].Value);
                     
                        if (shortestDistance == -1 || shortestDistance > newDistance)
                        {
                            //On récupère le nombre de vélos dispos
                            //Get the number of the Station 
                            String numPoint = elemList[i].Attributes["number"].Value;

                            // Create a request for the URL.
                            WebRequest request_for_data = WebRequest.Create("http://www.velib.paris/service/stationdetails/" + numPoint);

                            // Get Response 
                            WebResponse response_for_data = request_for_data.GetResponse();

                            // Open the stream using a StreamReader for easy access and put it into a string
                            Stream dataStream_for_data = response_for_data.GetResponseStream();
                            StreamReader reader_for_data = new StreamReader(dataStream_for_data); // Read the content.
                            string responseFromServer_for_data = reader_for_data.ReadToEnd(); // Put it in a String

                            // Parse the response and put the entries in XmlNodeList 
                            XmlDocument doc_for_data = new XmlDocument();
                            doc_for_data.LoadXml(responseFromServer_for_data);
                            XmlNodeList elemList_for_data = doc_for_data.GetElementsByTagName("available");

                            // Display the result 
                                
                            reader_for_data.Close();
                            response_for_data.Close();
                            int availableBikes = 0;
                            int.TryParse(elemList_for_data[0].FirstChild.Value, out availableBikes) ;

                            Debug.WriteLine("Number of available bikes: " + availableBikes);
                            //S'il y a des vélos dispos, ok, sinon on ignore cette station
                            if (availableBikes != 0)
                            {
                                velibAddress = elemList[i].Attributes["fullAddress"].Value;
                                shortestDistance = newDistance;
                            }
                        }
                    }
                    catch(NullReferenceException e)
                    {
                        
                    }
                   
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            // Clean up the streams and the response.
            reader.Close();
            response.Close();
        

            return velibAddress;
        }

       
    }
}
