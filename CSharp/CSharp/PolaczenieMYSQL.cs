﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Windows.Forms;

namespace CSharp
{
    class PolaczenieMYSQL
    {
        public static string strPolacz = "server=localhost;user=root;database=arduino;DefaultTableCacheAge=30;charset=utf8;";
        public MySqlConnection Polacz()
        {
            MySqlConnection polaczenie;
            polaczenie = new MySqlConnection(strPolacz);
            try
            {
                polaczenie.Open();
                MessageBox.Show("Połączono z bazą danych!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można połączyć z bazą danych. \n" + ex.Message);
            }
            return polaczenie;
        }
        public void zamknij(MySqlConnection polaczenie)
        {
            polaczenie.Close();
        }
    }
}
