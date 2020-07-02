using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Elgato_Keylight_External_Configurator
{
    public partial class ElgatoKeylightConfigurator : Form
    {
        const int port = 9123;

        string url = "";
        string displayName = "";

        public ElgatoKeylightConfigurator()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if(ConnectButton.Text == "Disconnect")
            {
                BrightnessTrackbar.Enabled = false;
                TemperatureTrackbar.Enabled = false;
                IpAddress.Enabled = true;
                ConnectButton.Text = "Connect";
                DisplayNameLabel.Text = "Not connected";
                url = "";
                displayName = "";

                return;
            }

            IPAddress ip;

            if(!IPAddress.TryParse(IpAddress.Text, out ip))
            {
                MessageBox.Show(
                    "Error trying to connect to Elgato Keylight",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            url = "http://" + ip.ToString() + ":" + port;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/elgato/accessory-info");
            request.Method = "GET";
            request.ContentType = "application/json";

            try
            {
                string jsonResponse = new StreamReader(((HttpWebResponse)request.GetResponse()).GetResponseStream()).ReadToEnd();

                if (!jsonResponse.Contains("Elgato"))
                    throw new Exception();

                // Without including a proper JSON lib...
                displayName = jsonResponse.Split(new string[] { "\"displayName\":\"" }, StringSplitOptions.None)[1].Split('"')[0];

                DisplayNameLabel.Text = "Connected to: " + displayName;

                BrightnessTrackbar.Enabled = true;
                TemperatureTrackbar.Enabled = true;
                IpAddress.Enabled = false;
                ConnectButton.Text = "Disconnect";
            }
            catch
            {
                MessageBox.Show(
                   "Incorrect response from Elgato Keylight",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
                return;
            }
        }

        private void changeValue(string name, int value)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/elgato/lights");
                request.Method = "PUT";
                request.ContentType = "application/json";

                string requestContent = "{\"lights\":[{\"on\":1,\"" + name + "\":" + value.ToString() + "}],\"numberOfLights\":1}";

                request.ContentLength = requestContent.Length;
                var sw = new StreamWriter(request.GetRequestStream());
                sw.Write(requestContent);
                sw.Close();

                request.GetResponse().Dispose();
            }
            catch
            {
            }
        }

        private void BrightnessTrackbar_Scroll(object sender, EventArgs e)
        {
            changeValue("brightness", BrightnessTrackbar.Value);
        }

        private void TemperatureTrackbar_Scroll(object sender, EventArgs e)
        {
            changeValue("temperature", TemperatureTrackbar.Value);
        }

        private void ElgatoKeylightConfigurator_Load(object sender, EventArgs e)
        {

        }
    }
}
