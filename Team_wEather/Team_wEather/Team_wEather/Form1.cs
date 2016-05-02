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


            string weburl = "http://api.openweathermap.org/data/2.5/weather?q=" + comboBox1.Text + ",us" + "&mode=xml" + "&appid=0122e9b39c4cbdb091984948bd3e4673";


            var xml = await new WebClient().DownloadStringTaskAsync(new Uri(weburl));

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string szTemp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
            double temp = double.Parse(szTemp) - 273.16;
            temp = (int)temp;
            lblTemp_output.Text = temp.ToString() + " " + string.Format("\u00B0") + (" Celcius");//converts output to string temp format

            double fahrenheit = (temp * (9/5)) + 32;
            lbl_tempFaren_Output.Text = fahrenheit.ToString() + " " + string.Format("\u00B0") + (" Fahrenheit");//converts output to string temp format
            // F = C * 5 / 9 + 32
        }

      

       
    }
}
