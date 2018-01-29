using GetHashAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Data.SQLite;

namespace GetHashAPI.Controllers
{
    public class UserController : ApiController
    {
        User[] users = new User[1005];
        [AcceptVerbs("POST", "PUT")]
        public IHttpActionResult AddUser(User user)
        {
            int index = BindSqlToVector();
            ++index;
            users[index] = user;
            AddToTableUsers(user);
            return Ok();

        }

        
        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public IHttpActionResult GetProduct(int id)
        {
            BindSqlToVector();
            var user = users.FirstOrDefault((p) => p.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        private int BindSqlToVector()
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
            return index;
        }

        public void AddToTableUsers(User newItem)
        {
            string query = "INSERT INTO users(id, username, password, wallet, reputation) VALUES" +
                "(@id, @username, @password, @wallet, @reputation)";
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";
            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                {
                    _cmd.Parameters.AddWithValue("@username", newItem.Username);
                    _cmd.Parameters.AddWithValue("@password", newItem.Password);
                    _cmd.Parameters.AddWithValue("@wallet", newItem.Wallet);
                    _cmd.Parameters.AddWithValue("@reputation", newItem.Reputation);
                    _cmd.ExecuteNonQuery();
                };
            };
        }

        public void DeleteFromTableUsers(int knownId)
        {
            string query = "DELETE FROM users WHERE id = knownId";
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

        public void DropTableUsers()
        {
            string query = "DROP TABLE users";
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

        public int GetReputation(int knownId)
        {
            try
            {
                string conString = "DataSource=D://fu.sqlite;Version=3;";
                string query = "SELECT reputation FROM users WHERE id = @param";
                SQLiteConnection _con = new SQLiteConnection(conString);
                _con.Open();
                SQLiteCommand _cmd = new SQLiteCommand(query, _con);
                _cmd.Parameters.AddWithValue("@param", knownId);
                int price = int.Parse(_cmd.ExecuteScalar().ToString());

                return (price);
            }
            catch (ArgumentNullException)
            {
                return (0);
            }
        }

        public int GetReputation(string knownUsername)
        {
            try
            {
                string conString = "DataSource=D://fu.sqlite;Version=3;";
                string query = "SELECT reputation FROM users WHERE username = @param";
                SQLiteConnection _con = new SQLiteConnection(conString);
                _con.Open();
                SQLiteCommand _cmd = new SQLiteCommand(query, _con);
                _cmd.Parameters.AddWithValue("@param", knownUsername);
                int price = int.Parse(_cmd.ExecuteScalar().ToString());

                return (price);
            }
            catch (ArgumentNullException)
            {
                return (0);
            }
        }

        public void UpdateReputation(int knownId, int changeRepIntPlusOrMinus)
        {
            int newReputation = GetReputation(knownId) + changeRepIntPlusOrMinus;
            string query = "UPDATE TABLE users SET reputation = @param WHERE id = knownId";
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";

            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                {
                    _cmd.Parameters.AddWithValue("@param", newReputation);
                    _cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateReputation(string knownUsername, int changeRepIntPlusOrMinus)
        {
            int newReputation = GetReputation(knownUsername) + changeRepIntPlusOrMinus;
            string query = "UPDATE TABLE users SET reputation = @param WHERE username = knownUsername";
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";

            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                {
                    _cmd.Parameters.AddWithValue("@param", newReputation);
                    _cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
