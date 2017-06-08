using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace CSharp
{
    public partial class Form1 : Form
    {
        public bool zapisAktywny = false;
        public bool pomiarAktywny = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bStartPomiar_Click(object sender, EventArgs e)
        {
            if (!(serialPort2.IsOpen))
            { 
                //Przychodzący
                serialPort2.Open();
                serialPort2.DtrEnable = true;
            }  
            if (serialPort2.IsOpen)
            {
                
                bStartPomiar.Enabled = false;
                bStopPomiar.Enabled = true;
                bStartZapis.Enabled = true;
            }                
        }

        private void bStopPomiar_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();

                bStartPomiar.Enabled = true;
                bStopPomiar.Enabled = false;
                bStartZapis.Enabled = false;
            }
        }

        private BackgroundWorker _workerZapis = null;
        private PolaczenieMYSQL polaczenieMYSQL = new PolaczenieMYSQL();
        private MySqlConnection polaczenie;
        private void bStartZapis_Click(object sender, EventArgs e)
        {
            if ((!((String.Compare(tbSensor1.Text.ToString(), "")) == 0)) && (!((String.Compare(tbSensor2.Text.ToString(), "")) == 0)))
            {
                polaczenie = polaczenieMYSQL.Polacz();
                if (polaczenieMYSQL.polaczono == true)
                {
                    zapisAktywny = true;
                    _workerZapis = new BackgroundWorker()
                    {
                        WorkerSupportsCancellation = true
                    };
                    _workerZapis.DoWork += new DoWorkEventHandler((state, args) =>
                    {
                        do
                        {
                            DateTime dzis = DateTime.UtcNow.Date;
                            string sqlSensor1 = "INSERT INTO pomiar (wartosc, czas, idSensor) VALUES ('" + tbSensor1.Text.ToString() + "', '" + dzis.ToString("yyyy/MM/dd") + "', '1');";
                            string sqlSensor2 = "INSERT INTO pomiar (wartosc, czas, idSensor) VALUES ('" + tbSensor2.Text.ToString() + "', '" + dzis.ToString("yyyy/MM/dd") + "', '2');";
                            MySqlCommand pytanie1 = new MySqlCommand(sqlSensor1, polaczenie);
                            pytanie1.ExecuteNonQuery();
                            MySqlCommand pytanie2 = new MySqlCommand(sqlSensor2, polaczenie);
                            pytanie2.ExecuteNonQuery();
                            System.Threading.Thread.Sleep(1000);
                        } while (zapisAktywny == true);
                    });
                    _workerZapis.RunWorkerAsync();
                    bStartZapis.Enabled = false;
                    bStopZapis.Enabled = true;
                }
            }
        }

        private void bStopZapis_Click(object sender, EventArgs e)
        {
            zapisAktywny = false;
            bStopZapis.Enabled = false;
            bStartZapis.Enabled = true;
            _workerZapis.CancelAsync();
            polaczenieMYSQL.Zamknij(polaczenie);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort2.Close();
        }
        public string otrzymane = "";
        private void wyswietl(object sender, EventArgs e)
        {
            string[] wartosci = otrzymane.Split(':');
            tbSensor1.Text = wartosci[0].ToString();
            tbSensor2.Text = wartosci[1].ToString();
        }
        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            otrzymane = serialPort2.ReadLine();
            this.Invoke(new EventHandler(wyswietl));
        }


    }
}
