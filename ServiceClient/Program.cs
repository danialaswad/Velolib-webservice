using ServiceClient.VelibServiceTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ItineraryServiceClient isc = new ItineraryServiceClient("netTcp");
            Program p = new Program();
            Console.WriteLine("Welcome to Velib itinerary Service");
            Console.Write("Enter origin [default address : 5 Avenue Anatole France, 75007 Paris ] : ");
            string origin = Console.ReadLine();
            if (origin.Equals(""))
            {
                origin = "5 Avenue Anatole France, 75007 Paris";
            }
            Console.Write("Enter destination [default address : Avenue des Champs-Élysées, 75008 Paris ] : ");
            string destination = Console.ReadLine();
            if (destination.Equals(""))
            {
                destination = "Avenue des Champs-Élysées, 75008 Paris";
            }
            // "21 Rue Saint-Séverin 75005", "1 rue Antoine Dubois"
            string s = isc.getItinerary(origin, destination);

            p.response_processor(s);
            Console.WriteLine("Press key to exit");
            Console.ReadLine();
        }
        private void response_processor(string s)
        {
            JToken token = JObject.Parse(s);

            JToken walk = JObject.Parse(token.SelectToken("walk").ToString());

            Console.WriteLine("Walking itinerary");
            Console.WriteLine("Start : "+(string)walk.SelectToken("start"));
            Console.WriteLine("End : "+(string)walk.SelectToken("end"));

            JToken wDistance = JObject.Parse(walk.SelectToken("distance").ToString());
            JToken wDuration = JObject.Parse(walk.SelectToken("duration").ToString());
            Console.WriteLine("Duration : " + (string)wDuration.SelectToken("text"));
            Console.WriteLine("Distance : " + (string)wDistance.SelectToken("text"));

            JArray wSteps = JArray.Parse(walk.SelectToken("steps").ToString());
            add_to_list_view(wSteps);

            JToken cycle = JObject.Parse(token.SelectToken("cycle").ToString());

            Console.WriteLine("Cycling itinerary");
            Console.WriteLine("Start : " + (string)cycle.SelectToken("start"));
            Console.WriteLine("End : " + (string)cycle.SelectToken("end"));
            JToken cDistance = JObject.Parse(cycle.SelectToken("distance").ToString());
            JToken cDuration = JObject.Parse(cycle.SelectToken("duration").ToString());
            Console.WriteLine( "Distance : " + (string)cDistance.SelectToken("text"));
            Console.WriteLine("Duration : " + (string)cDuration.SelectToken("text"));

            JArray cSteps = JArray.Parse(cycle.SelectToken("steps").ToString());
            add_to_list_view(cSteps);
        }

        private void add_to_list_view(JArray array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                JToken current = JObject.Parse(array[i].ToString());
                string dist = (string)JObject.Parse(current.SelectToken("distance").ToString()).SelectToken("text");
                string dur = (string)JObject.Parse(current.SelectToken("duration").ToString()).SelectToken("text");
                string info = (string)current.SelectToken("html_instructions");
                Console.WriteLine("Instructions : " + info 
                    + " | Distance : " + dist 
                    + " | Duration : " + dur  );
            }
        }
    }
}
