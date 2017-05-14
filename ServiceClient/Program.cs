using ServiceClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ItineraryServiceClient isc = new ItineraryServiceClient();
            string s=isc.getItinerary("21 Rue Saint-Séverin 75005", "1 rue Antoine Dubois");
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
