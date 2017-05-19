using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;



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
        
            JObject jCycle = new JObject();
            jCycle.Add("start", velibAddress);
            jCycle.Add("end", jsonCycle.routes[0].legs[0].end_address);
            jCycle.Add("distance", jsonCycle.routes[0].legs[0].distance);
            jCycle.Add("duration", jsonCycle.routes[0].legs[0].duration);

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



        static string parsePostalCode(string address)
        {
            Match match=Regex.Match(address, "(.*)([0-9][0-9][0-9][0-9][0-9])(.*)");
            return match.Groups[2].Value;
        }

        //Calcul durée trajet entre origin et un point velib

        static int getTimeToTravel(string origin, string velibAddress)
        {
            string apiKey = "AIzaSyCMl0p5Kfa992OF5n0B89hL8l9KU-LUAQg";
            WebRequest request = WebRequest.Create("https://maps.googleapis.com/maps/api/distancematrix/xml?units=metric&origins=" + origin + "&destinations=" + velibAddress + "&mode=bicycling&key=" + apiKey);
            // Get Response from the Service 
            WebResponse response = request.GetResponse();

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access and put it into a string
            StreamReader reader = new StreamReader(dataStream); // Read the content.
            string responseFromServer = reader.ReadToEnd(); // Put it in a String 
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(responseFromServer);

            XmlNodeList elemList = xdoc.GetElementsByTagName("duration");
            
            int time = 0;
            int.TryParse(elemList[0].SelectSingleNode("value").InnerText, out time);

            reader.Close();
            response.Close();

            return time;
        }

        


        static String getClosestVelib(string origin)
        {
            int shortestDistance = -1;
            string velibAddress = "";
            string postalCode = parsePostalCode(origin);
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
                //Test if the substring is in the name of the station  
                try
                {
                

                    if (postalCode.Equals("") || elemList[i].Attributes["fullAddress"].Value.Contains(postalCode))
                    {
                        //TODO vérifier si des velibs sont dispos, sinon ignorer
                        //On calcule la distance avec les velibs pour trouver le velib le plus proche
                        try
                        {
                            int newDistance = getTimeToTravel(origin, elemList[i].Attributes["fullAddress"].Value);
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
