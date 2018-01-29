using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Bitcoin_App_TradeMarket_PoliHack
{
    class Database
    {
        public SQLiteConnection _con;
        private bool isConnected = false;
        private string conString = "DataSource=bitcoin.sqlite;Version=3";

        public void ConnectDatabase()
        {
            if (!isConnected)
            {
                try
                {
                    _con = new SQLiteConnection(conString);
                    _con.Open();
                    isConnected = true;
                    MessageBox.Show("connected");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void CloseConnection()
        {
            if (isConnected)
            {
                _con.Close();
                isConnected = false;
            }
        }

        public SQLiteConnection GetConnection()
        {
            if (!isConnected)
                ConnectDatabase();
            return (_con);
        }
    }
}
