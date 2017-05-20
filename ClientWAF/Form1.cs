using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ClientWAF.VelibService;

namespace ClientWAF
{
    public partial class Form1 : Form
    {
        private ItineraryServiceClient ics;

        public Form1()
        {
            InitializeComponent();
            ics = new ItineraryServiceClient("wsHttp");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String src = textBox1.Text;
            String dest = textBox2.Text;

            String res = ics.getItinerary("21 Rue Saint-Séverin 75005", "1 rue Antoine Dubois");
            response_processor(res);
            //walkStart.Text = res;
            //walkStart.Visible = true;
        }       


        private void response_processor(string s)
        {
            dynamic json = JsonConvert.DeserializeObject(s);

            string wStart = json.walk.start;
            string wEnd = json.walk.end;
            walkStart.Text = json.walk.start;
            walkStart.Visible = true;
            walkEnd.Text = json.walk.end;
            walkEnd.Visible = true;
            walkDuration.Text = "Duration : " + json.walk.duration.text;
            walkDuration.Visible = true;
            walkDistance.Text = "Distance : " + json.walk.distance.text;
            walkDistance.Visible = true;

            ListViewItem lv1 = new ListViewItem();
            lv1.SubItems.Add(json.walk.steps);
            walkView.Items.Add(lv1);
            walkView.Visible = true;



            string cStart = json.cycle.start;
            string cEnd = json.cycle.end;
            cycleStart.Text = json.cycle.start;
            cycleStart.Visible = true;
            cycleEnd.Text = json.cycle.end;
            cycleEnd.Visible = true;
            cycleDistance.Text = "Distance : " + json.cycle.distance.text;
            cycleDistance.Visible = true;
            cycleDuration.Text = "Duration : " + json.cycle.duration.text;
            cycleDuration.Visible = true;

            walkPicture.Visible = true;
            cyclePicture.Visible = true;

        }

        private void launch_browser(System.Windows.Forms.WebBrowser browser, string start, string end, string tmode)
        {
             /***
              * https://www.google.com/maps/dir/?api=1&origin=&destination=&travelmode=bicycling
              */

            string url = "https://www.google.com/maps/dir/?api=1";

            string origin = "&origin=" + start.Replace(' ', '+');
            string destination = "&destination=" + end.Replace(' ', '+');
            string mode = "&travelmode=" + tmode;

            StringBuilder sbuilder = new StringBuilder();
            sbuilder.Append(url).Append(origin).Append(destination).Append(mode);
            
            browser.Navigate(sbuilder.ToString());
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
