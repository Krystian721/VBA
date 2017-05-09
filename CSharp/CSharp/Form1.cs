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
            if (!(serialPort1.IsOpen))
                serialPort1.Open();
            serialPort1.WriteLine("1");
            
        }

        private void bStopPomiar_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("2");
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private BackgroundWorker _worker = null;
        private PolaczenieMYSQL polaczenieMYSQL = new PolaczenieMYSQL();
        private MySqlConnection polaczenie;
        private void bStartZapis_Click(object sender, EventArgs e)
        {
            zapisAktywny = true;
            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;
            polaczenie = polaczenieMYSQL.Polacz();
            _worker.DoWork += new DoWorkEventHandler((state, args) =>
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
            _worker.RunWorkerAsync();
            bStartZapis.Enabled = false;
            bStopZapis.Enabled = true;
        }

        private void bStopZapis_Click(object sender, EventArgs e)
        {
            zapisAktywny = false;
            bStopZapis.Enabled = false;
            bStartZapis.Enabled = true;
            _worker.CancelAsync();
            polaczenieMYSQL.Zamknij(polaczenie);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

    }
}
