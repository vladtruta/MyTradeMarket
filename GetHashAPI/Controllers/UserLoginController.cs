using GetHashAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Data.SQLite;

namespace GetHashAPI.Controllers
{
    public class UserLoginController : ApiController
    {
        public bool DoLogin(string user, string pass)
        {
            int count = 0;
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";
            string query = "SELECT * FROM users WHERE username = @param1 AND password = @param2";

            try
            {
                using (SQLiteConnection _con = new SQLiteConnection(conString))
                {
                    _con.Open();
                    using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                    {
                        _cmd.Parameters.AddWithValue("@param1", user);
                        _cmd.Parameters.AddWithValue("@param2", pass);
                        using (SQLiteDataReader _rdr = _cmd.ExecuteReader())
                        {
                            while (_rdr.Read())
                                count++;
                            _rdr.Close();
                            if (count == 1)
                                return (true);
                            else
                                return (false);
                        };
                    };
                };
            }
            catch (ArgumentNullException)
            {
                return (false);
            }
        }
        User[] users = new User[1005];
        [AcceptVerbs("POST", "PUT")]
        public IHttpActionResult Login(UserLogin login)
        {
            BindSqlToVector();
            if (DoLogin(login.user, login.password)) return Ok();
            else return NotFound();
        }
        private void BindSqlToVector()
        {
            int index = 0;
            string query = "SELECT * FROM users";
            string conString = "DataSource=D:\\fu.sqlite;Version=3";

            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                using (SQLiteDataReader _rdr = _cmd.ExecuteReader())
                {

                    while (_rdr.Read())
                    {
                        string username = (string)_rdr["username"];
                        string password = (string)_rdr["password"];
                        string wallet = (string)_rdr["wallet"];
                        int reputation = int.Parse(_rdr["reputation"].ToString());

                        User toBeAdd = new User();

                        toBeAdd.Id = index + 1;
                        toBeAdd.Username = username;
                        toBeAdd.Wallet = wallet;
                        toBeAdd.Reputation = reputation;

                        users[index] = toBeAdd;
                        index++;
                    }
                    _con.Close();
                };
            };
        }
        
    }
}