using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientWAF.ItineraryService;

namespace ClientWAF
{
    public partial class Form1 : Form
    {
        private ItineraryServiceClient ics;

        public Form1()
        {
            InitializeComponent();
            ics = new ItineraryServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String src = textBox1.Text;
            String dest = textBox2.Text;

            String res = ics.getItinerary("21 Rue Saint-Séverin, 75005 Paris", "1 Rue Antoine Dubois, 75006 Paris");

            richTextBox1.Text = res;
        }
    }
}
