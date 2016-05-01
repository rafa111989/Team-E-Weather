using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace Team_wEather
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {


            string weburl = "http://api.openweathermap.org/data/2.5/weather?q=" + txtBx_Zip.Text + ",us" + "&mode=xml" + "&appid=0122e9b39c4cbdb091984948bd3e4673";


            var xml = await new WebClient().DownloadStringTaskAsync(new Uri(weburl));

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string szTemp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
            double temp = double.Parse(szTemp) - 273.16;
            lblTemp_output.Text = temp + (" Celcius");

            double fahrenheit = (temp * (9/5)) + 32;
            lbl_tempFaren_Output.Text = fahrenheit + ("Fahrenheit");
            // F = C * 5 / 9 + 32
        }

       
    }
}
