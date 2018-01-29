using GetHashAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Data.SQLite;

namespace GetHashAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[1005];

        [AcceptVerbs("POST", "PUT")]
        public IHttpActionResult Add(Product product)
        {
            int index = BindSqlToVector();
            ++index;
            products[index] = product;
            AddToTableProduct(product);
            return Ok();
        }
        public IHttpActionResult GetProduct(int id)
        {
            Product tampenie = new Product();
            tampenie.Id = 0;
            tampenie.Name = "NOT AVAILABLE";
            tampenie.Price = 0;
            tampenie.Description = "NOT AVAILABLE";
            tampenie.Seller = "NOT AVAILABLE";
            tampenie.Tag1 = "NOT AVAILABLE";
            tampenie.Tag2 = "NOT AVAILABLE";
            tampenie.Tag3 = "NOT AVAILABLE";
            tampenie.User_id = 0;
            tampenie.Image_url = "NOT AVAILABLE";
            Product product = new Product();
            product = null;
            BindSqlToVector();
            if (products[id] != null)
               product = products[id];
            if (product == null)
            {
                return Ok(tampenie);
            }
            return Ok(product);
      
        }

        public int BindSqlToVector()
        {
            int index = 0;
            string query = "SELECT * FROM product";
            string conString = "DataSource=D:\\fu.sqlite;Version=3";

            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                using (SQLiteDataReader _rdr = _cmd.ExecuteReader())
                {

                    while (_rdr.Read())
                    {
                        string name = (string)_rdr["title"];
                        string description = (string)_rdr["description"];
                        string tag1 = (string)_rdr["tag1"];
                        string tag2 = (string)_rdr["tag2"];
                        string tag3 = (string)_rdr["tag3"];
                        double price = double.Parse(_rdr["price"].ToString());
                        int user_id = int.Parse(_rdr["user_id"].ToString());
                        string image_url = (string)_rdr["image_url"];
                        //string seller = (string)_rdr["seller"];

                        Product toBeAdd = new Product();

                        toBeAdd.Id = index + 1;
                        toBeAdd.Name = name;
                        toBeAdd.Price = price;
                        toBeAdd.Description = description;
                        //toBeAdd.Seller = seller;
                        toBeAdd.Tag1 = tag1;
                        toBeAdd.Tag2 = tag2;
                        toBeAdd.Tag3 = tag3;
                        toBeAdd.User_id = user_id;
                        toBeAdd.Image_url = image_url;

                        products[index] = toBeAdd;
                        index++;
                    }
                    _con.Close();
                };
            };
            return index;
        }

        public void AddToTableProduct(Product newItem)
        {
            string query = "INSERT INTO product(id, title, description, tag1, tag2, tag3, price, user_id, image_url, seller)" +
                   "VALUES(@id, @title, @description, @tag1, @tag2, @tag3, @price, @user_id, @image_url, @seller)";
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";

            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                {
                    _cmd.Parameters.AddWithValue("@title", newItem.Name);
                    _cmd.Parameters.AddWithValue("@description", newItem.Description);
                    _cmd.Parameters.AddWithValue("@tag1", newItem.Tag1);
                    _cmd.Parameters.AddWithValue("@tag2", newItem.Tag2);
                    _cmd.Parameters.AddWithValue("@tag3", newItem.Tag3);
                    _cmd.Parameters.AddWithValue("@price", newItem.Price);
                    _cmd.Parameters.AddWithValue("@user_id", newItem.User_id);
                    _cmd.Parameters.AddWithValue("@image_url", newItem.Image_url);
                    _cmd.Parameters.AddWithValue("@seller", newItem.Seller);
                    _cmd.ExecuteNonQuery();
                }; 
           };
        }

        public void DeleteFromTableProduct(int knownId)
        {
            string query = "DELETE FROM product WHERE id = knownId";
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";
            
            using  (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                {
                    _cmd.ExecuteNonQuery();
                }
            } 
        }

        public void DeleteFromTableProduct(string knownUsername)
        {
            string query = "DELETE FROM product WHERE username = knownUsername";
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

        public void DropTableProduct()
        {
            string query = "DROP TABLE product";
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