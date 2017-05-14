﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;



namespace ServiceWCF
{
    public class ItineraryService : IItineraryService
    {
        public string getItinerary(string origin, string destination)
        {
            string itinerary = "";
            string velibAddress = getVelib(origin);
            itinerary += connectToMaps(origin, velibAddress);
            itinerary += connectToMaps(velibAddress, destination);

            return itinerary;
           
            //return string.Format("You entered: {0}", value);
        }

        public static String connectToMaps(string origin, string destination)
        {
            string apiKey = "AIzaSyA-1i10h9yGuytFsM8uQN9kzfq-NaYVsHU";
            destination = destination.Replace(' ', '+');
            origin = origin.Replace(' ', '+');
            WebRequest request = WebRequest.Create("https://maps.googleapis.com/maps/api/directions/json?origin="+origin+"&destination=" + destination + "&key=" + apiKey);

            // Get Response from the Service 
            WebResponse response = request.GetResponse();

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access and put it into a string
            StreamReader reader = new StreamReader(dataStream); // Read the content.
            string responseFromServer = reader.ReadToEnd(); // Put it in a String 
            return responseFromServer;
        }

        static string parsePostalCode(string address)
        {
            Match match=Regex.Match(address, "(.*)([0-9][0-9][0-9][0-9][0-9])(.*)");
            Debug.WriteLine(match.Groups[2].Value);
            return match.Groups[2].Value;
        }


        static String getVelib(string origin)
        {
            string strresp = "";
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
                
                    if (elemList[i].Attributes["fullAddress"].Value.Contains(postalCode))
                    {
                        return elemList[i].Attributes["fullAddress"].Value;
                        /* POUR PLUS TARD
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

                        strresp += elemList_for_data[0].FirstChild.Value;
                        strresp += " bikes are available ";
                        strresp += "at " + elemList[i].Attributes["name"].Value;
                        reader_for_data.Close();
                        response_for_data.Close();
                        */
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

            return strresp;
        }

       
    }
}
