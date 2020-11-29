using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Net;

namespace COM_to_Thingspeak
{
    public partial class Form1 : Form
    {

        System.IO.Ports.SerialPort Port;

        bool IsClosed = false;

        public Form1()
        {
            InitializeComponent();

            PORTOVI.Text = "COM0";
            visina_senzor.Text = "200";

            PORTOVI.Items.Clear();

            string[] ports = SerialPort.GetPortNames();
            foreach (string comport in ports)
            {
                PORTOVI.Items.Add(comport);
            }
        }

        private void Serijska_komunikacija(string port, string visina_senzora)
        {
            visina_senzor.Text = visina_senzora;

            Port = new System.IO.Ports.SerialPort();
            Port.PortName = port;
            Port.BaudRate = 115200;
            Port.ReadTimeout = 500;

            try
            {
                Port.Open();
            }

            catch { }


        }

        private void ListenSerial()
        {
            while (!IsClosed)
            {
                try
                {
                    //read to data from arduino
                    string AString = Port.ReadLine();

                    //write the data in something textbox
                    Dolazni_podatci.Invoke(new MethodInvoker(
                        delegate
                        {

                            SaveMeasurementData(AString);

                        }
                        ));

                }
                catch { }
            }


        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when the form will be closed this line close the serial port
            IsClosed = true;
            if (Port.IsOpen)
                Port.Close();

        }

        void SaveMeasurementData(string izmjerena_velicina)
        {
            string apiKey;

            var server = "https://api.thingspeak.com/";
            string webMethod;
            string uri;
            var webclient = new WebClient();
            apiKey = "ZSM3Z9SM8ET99HYT";

            Dolazni_podatci.Text = izmjerena_velicina;

            int position = izmjerena_velicina.IndexOf(":");

            string vrj2 = izmjerena_velicina.Substring(0, position);

            int visina_snijega = Convert.ToInt32(visina_senzor.Text) - Convert.ToInt32(vrj2);


            visina_snijega_je.Text = visina_snijega.ToString();

            webMethod = "update?api_key=" + apiKey + "&field1=" + visina_snijega;
            uri = server + webMethod;
            webclient.UploadString(uri, "POST", "");

        }



        private void pretrazi_Click(object sender, EventArgs e)
        {
            PORTOVI.Items.Clear();

            string[] ports = SerialPort.GetPortNames();
            foreach (string comport in ports)
            {
                PORTOVI.Items.Add(comport);
            }
        }

        private void PORTOVI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void visina_senzor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zapocni_Click(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(ListenSerial);
            Hilo.Start();
            Serijska_komunikacija(PORTOVI.Text, visina_senzor.Text);
        }

        private void Dolazni_podatci_TextChanged(object sender, EventArgs e)
        {

        }

        private void visina_snijega_je_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
