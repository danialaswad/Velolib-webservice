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

        private void button1_Click(object sender, EventArgs e)
        {
            String src = textBox1.Text;
            String dest = textBox2.Text;

            String res = ics.getItinerary(textBox1.Text, textBox2.Text);

            response_processor(res);
            //walkStart.Text = res;
            //walkStart.Visible = true;
        }


        private void response_processor(string s)
        {
            dynamic json = JsonConvert.DeserializeObject(s);
            
            walkStart.Text = json.walk.start;
            walkStart.Visible = true;
            walkEnd.Text = json.walk.end;
            walkEnd.Visible = true;
            walkDuration.Text = "Duration : " + json.walk.duration.text;
            walkDuration.Visible = true;
            walkDistance.Text = "Distance : " + json.walk.distance.text;
            walkDistance.Visible = true;

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

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
