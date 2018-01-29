using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Net;
using System.Threading;

namespace Bitcoin_App_TradeMarket_PoliHack
{
    public partial class Main : Form
    {
        Hash[] hashes = new Hash[1005];

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CreateTagIdTable();
            CreateUsersTable();
            CreateTableProductTable();

          //  CreateTransactionTable();
            doSql();
            while (true) { PutInArrayOfDecimal(); Thread.Sleep(2000); }
            //pictureBox1.AllowDrop = true;
            //initDragging();
        }
        /*
        private void initDragging()
        {
            pictureBox1.DragEnter += (s, ev) =>
            {
                if (ev.Data.GetDataPresent(DataFormats.FileDrop))
                    ev.Effect = DragDropEffects.Copy;
                else
                    ev.Effect = DragDropEffects.None;
            };

            pictureBox1.DragDrop += (s, ev) =>
            {
                string[] _path = (string[])(ev.Data.GetData(DataFormats.FileDrop));

                foreach (string file in _path)
                {
                    if (File.Exists(file))
                    {
                        Image img = Image.FromFile(file);
                        pictureBox1.Image = resizeImageForPictureBox(pictureBox1, img);
                    }
                }
            };
        }

        private Image resizeImageForPictureBox(PictureBox pb, Image oldImg)
        {
            Bitmap img = new Bitmap(pb.Size.Width, pb.Size.Height);
            Graphics graphObj = Graphics.FromImage(img);

            graphObj.DrawImage(oldImg, 0, 0, pb.Size.Width, pb.Size.Height);
            return (img);
        }*/

        private void createDataBase()
        {
            try
            {
                SQLiteConnection.CreateFile("fu.sqlite");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CreateTagIdTable()
        {
            try
            {
                string conString = "DataSource=D:\\fu.sqlite;Version=3";
                string query = "CREATE TABLE IF NOT EXISTS tagids(" +
                                "id INTEGER PRIMARY KEY," +
                                "tag VARCHAR(128) NOT NULL" +
                                ");";
                SQLiteConnection _con = new SQLiteConnection(conString);
                _con.Open();
                SQLiteCommand _cmd = new SQLiteCommand(query, _con);
                _cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CreateUsersTable()
        {
            try
            { 
                string query =  "CREATE TABLE IF NOT EXISTS users (" +
                                "id INTEGER PRIMARY KEY," +
                                "username VARCHAR(35) NOT NULL," +
                                "password VARCHAR(35) NOT NULL," +
                                "wallet VARCHAR(100)," +
                                "reputation INTEGER" +
                                "); ";
                string conString = "DataSource=D:\\fu.sqlite;Version=3;";
                SQLiteConnection _con = new SQLiteConnection(conString);
                _con.Open();
                SQLiteCommand _cmd = new SQLiteCommand(query, _con);
                _cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CreateTableProductTable()
        {
            try
            {
                string query =  "CREATE TABLE IF NOT EXISTS product(" +
                                "id INTEGER PRIMARY KEY," +
                                "title VARCHAR(100) NOT NULL," +
                                "description VARCHAR(500)," +
                                "tag1 VARCHAR(30) NOT NULL," +
                                "tag2 VARCHAR(30) NOT NULL," +
                                "tag3 VARCHAR(30) NOT NULL," +
                                "price FLOAT," +
                                "user_id INTEGER," +
                                "image_url VARCHAR(150)," +
                                "FOREIGN KEY(user_id) REFERENCES users(id)" +
                                ");";
                string conString = "DataSource=D:\\fu.sqlite;Version=3;";
                SQLiteConnection _con = new SQLiteConnection(conString);
                _con.Open();
                SQLiteCommand _cmd = new SQLiteCommand(query, _con);
                _cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CreateTransactionTable()
        {
            try
            {
                string query =  "CREATE TABLE IF NOT EXISTS transactions (" +
                                "id INTEGER PRIMARY KEY," +
                                "reputation INTEGER," +
                                "shakehands VARCHAR(128)," +
                                "pay VARCHAR(128) NOT NULL," +
                                "product_id INTEGER," +
                                "FOREIGN KEY (product_id) REFERENCES product(id)" + 
                                ");";
                // Aparent nu poti avea nume de tabele / baze de date care referentiaza o clasa din alt assembly .. 
                // mda .. rip 15 min

                string conString = "DataSource=D:\\fu.sqlite;Version=3;";
                SQLiteConnection _con = new SQLiteConnection(conString);
                _con.Open();
                SQLiteCommand _cmd = new SQLiteCommand(query, _con);
                _cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void doSql()
        {
            try
            {
                int index = 0;
                string query = "SELECT * FROM tagids";
                string conString = "DataSource=D:\\fu.sqlite;Version=3";

                using (SQLiteConnection _con = new SQLiteConnection(conString))
                {
                    _con.Open();
                    using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                    using (SQLiteDataReader _rdr = _cmd.ExecuteReader())
                    {

                        while (_rdr.Read())
                        {
                            string hash = (string)_rdr["tag"];

                            Hash toBeAdd = new Hash();

                            toBeAdd.id = index + 1;
                            toBeAdd.hash = hash;

                         //   textBox1.Text += toBeAdd.id.ToString() + " " + toBeAdd.hash.ToString() + Environment.NewLine;
                            hashes[index] = toBeAdd;
                            index++;
                        }
                        _con.Close();
                    };
                };
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int GetScalarFromTabel()
        {
            try
            {
                string conString = "DataSource=D://fu.sqlite;Version=3;";
                string query = "SELECT price FROM product WHERE tag1 = @param";
                SQLiteConnection _con = new SQLiteConnection(conString);
                _con.Open();
                SQLiteCommand _cmd = new SQLiteCommand(query, _con);
                _cmd.Parameters.AddWithValue("@param", "fain");
                int price = int.Parse(_cmd.ExecuteScalar().ToString());

                return (price);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public decimal getBalance(string walletID)
        {
            ///api/v2/get_address_balance/?api_key=API KEY&addresses=ADDRESS1,ADDRESS2,...
            string apiKey = "9d77-f4fb-76fe-7ca3";
            string pin = "veresmort";
            string firstPart = "https://block.io/api/v2/";
            string request = firstPart + "get_address_balance/?api_key=" + apiKey + "&addresses=" + walletID;
            decimal currentBalance = new decimal();

            try
            {
                WebRequest web = WebRequest.Create(request);
                HttpWebResponse response = (HttpWebResponse)web.GetResponse();
                Stream writen = response.GetResponseStream();
                StreamReader reader = new StreamReader(writen);

                string toBeRead;
                while ((toBeRead = reader.ReadLine()) != null)
                {
                    if (toBeRead.Contains("available_balance"))
                    {
                        string[] getLine = toBeRead.Split('"');
                        try
                        {
                            string balance = getLine[3];
                            balance.Trim();
                            currentBalance = Convert.ToDecimal(balance);
                        }
                        catch
                        {
                            MessageBox.Show("Unable to get wallet money!");

                            return (0);
                        }
                    }
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nPlease connect to the Internet!");
                return (0);
            }
            return (currentBalance);
        }
        public decimal estimateNetworkFees(decimal ammount, string tag2)
        {
            return 1;
        }

        public void PutInArrayOfDecimal()
        {
            int index = 0;
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";
            string query = "SELECT tag1,tag2,user_id FROM product";

            
            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                using (SQLiteDataReader _rdr = _cmd.ExecuteReader())
                { 
                        while (_rdr.Read())
                        {
                            string tag1 = _rdr["tag1"].ToString();
                            string tag2 = _rdr["tag2"].ToString();
                            decimal balance = getBalance(tag1);

                            if (balance > 0)
                            {
                             //   UpdateUserId(tag1, -1);
                             //   if(!user_id) DeleteFromTableProduct(tag1);
                                WebAPI.MakeTransaction(tag1, tag2, balance - estimateNetworkFees(balance, tag2));
                            }
                        }
                    
                };
            }
        }

        public int GetUserId(string tag)
        {
            try
            {
                string conString = "DataSource=D://fu.sqlite;Version=3;";
                string query = "SELECT user_id FROM product WHERE tag1 = @param";
                SQLiteConnection _con = new SQLiteConnection(conString);
                _con.Open();
                SQLiteCommand _cmd = new SQLiteCommand(query, _con);
                _cmd.Parameters.AddWithValue("@param", tag);
                int price = int.Parse(_cmd.ExecuteScalar().ToString());

                return (price);
            }
            catch (ArgumentNullException)
            {
                return (0);
            }
        }

        public void UpdateUserId(string tag, int changeRepIntPlusOrMinus)
        {
            int newReputation = GetUserId(tag) + changeRepIntPlusOrMinus;
            string query = "UPDATE TABLE product SET user_id = @param WHERE tag1 = tag";
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";

            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                {
                    _cmd.Parameters.AddWithValue("@param", tag);
                    _cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteFromTableProduct(string tag)
        {
            string query = "DELETE FROM product WHERE tag1 = tag";
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";

            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                {
                    _cmd.ExecuteNonQuery();
                }
            }
        }

    } 
}