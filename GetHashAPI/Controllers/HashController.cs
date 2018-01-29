using System;
using GetHashAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Data.SQLite;

namespace GetHashAPI.Controllers
{
    public class HashController : ApiController
    {
        Hash[] hashes = new Hash[1005];
        public IHttpActionResult Add(Hash hash)
        {
            int index = BindSqlToVector();
            ++index;
            hashes[index] = hash;
            AddToTableHash(hash);
            return Ok();
        }

        public IHttpActionResult GetHash(int id)
        {
            BindSqlToVector();
            var hash = hashes.FirstOrDefault((p) => p.Id == id);
            if (hash == null)
            {
                return NotFound();
            }
            return Ok(hash);
        }

        public int BindSqlToVector()
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

                        toBeAdd.Id = index + 1;
                        toBeAdd.hash = hash;

                        hashes[index] = toBeAdd;
                        index++;
                    }
                    _con.Close();
                };
            };
            return index;
        }

        public void AddToTableHash(Hash newItem)
        {
            string query = "INSERT INTO tagdis(id, tag,) VALUES(null,@tag)";
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";
            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                {
                    _cmd.Parameters.AddWithValue("@tag", newItem.hash);
                    _cmd.ExecuteNonQuery();
                };
            };
        }

        public void DeleteFromTableUsers(int knownId)
        {
            string query = "DELETE FROM tagids WHERE id = knownId";
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
            string query = "DROP TABLE tagids";
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