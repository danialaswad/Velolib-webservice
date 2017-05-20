using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using ClientWAF.VelibService;
using System.Text.RegularExpressions;

namespace ClientWAF
{
    public partial class Form1 : Form
    {
        private ItineraryServiceClient ics;

        public Form1()
        {
            InitializeComponent();
            ics = new ItineraryServiceClient("netTcp");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String src = textBox1.Text;
            String dest = textBox2.Text;
            if (src.Equals(""))
            {
                src = "5 Avenue Anatole France, 75007 Paris";
            }
            if (dest.Equals(""))
            {
                dest = "Avenue des Champs-Élysées, 75008 Paris";
            }
            // src = 5 Avenue Anatole France, 75007 Paris
            // dest = Avenue des Champs-Élysées, 75008 Paris
            String res = ics.getItinerary(src,dest);
            response_processor(res);
            //walkStart.Text = res;
            //walkStart.Visible = true;
        }       


        private void response_processor(string s)
        {
            JToken token = JObject.Parse(s);

            JToken walk = JObject.Parse(token.SelectToken("walk").ToString());

            walkStart.Text = (string) walk.SelectToken("start");
            walkEnd.Text = (string)walk.SelectToken("end");

            JToken wDistance = JObject.Parse(walk.SelectToken("distance").ToString());
            JToken wDuration = JObject.Parse(walk.SelectToken("duration").ToString());
            walkDuration.Text = "Duration : " + (string)wDuration.SelectToken("text");
            walkDistance.Text = "Distance : " + (string)wDistance.SelectToken("text");

            JArray wSteps = JArray.Parse(walk.SelectToken("steps").ToString());
            add_to_list_view(wSteps, walkView);

            JToken cycle = JObject.Parse(token.SelectToken("cycle").ToString());
            cycleStart.Text = (string)cycle.SelectToken("start");
            cycleEnd.Text = (string)cycle.SelectToken("end");
            JToken cDistance = JObject.Parse(cycle.SelectToken("distance").ToString());
            JToken cDuration = JObject.Parse(cycle.SelectToken("duration").ToString());
            cycleDistance.Text = "Distance : " + (string)cDistance.SelectToken("text");
            cycleDuration.Text = "Duration : " + (string)cDuration.SelectToken("text");

            JArray cSteps = JArray.Parse(cycle.SelectToken("steps").ToString());
            add_to_list_view(cSteps, cycleView);
        }

        private void add_to_list_view(JArray array, System.Windows.Forms.ListView view)
        {
            for (int i = 0; i < array.Count; i++)
            {
                JToken current = JObject.Parse(array[i].ToString());
                string dist = (string)JObject.Parse(current.SelectToken("distance").ToString()).SelectToken("text");
                string dur = (string)JObject.Parse(current.SelectToken("duration").ToString()).SelectToken("text");
                string info = (string)current.SelectToken("html_instructions");
                ListViewItem lv1 = new ListViewItem(remove_tag(info));
                lv1.SubItems.Add(dist);
                lv1.SubItems.Add(dur);
                view.Items.Add(lv1);
            }
        }
        private string remove_tag(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void walkView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cycleView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
    
}
