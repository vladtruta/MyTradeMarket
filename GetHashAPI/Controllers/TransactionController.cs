using GetHashAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.SQLite;

namespace GetHashAPI.Controllers
{
    public class TransactionController : ApiController
    {
        Transaction[] transactions = new Transaction[1005];
        [AcceptVerbs("POST", "PUT")]
        public IHttpActionResult Add(Transaction transaction)
        {
            int index = BindSqlToVector();
            ++index;
            transactions[index] = transaction;
            return Ok();
        }
        public IHttpActionResult GetTransaction(int id)
        {
            BindSqlToVector();
            var transaction = transactions.FirstOrDefault((p) => p.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }
            return Ok(transaction);
        }
        public IEnumerable<Transaction> GetAllTransactions()
        {
            return transactions;
        }

        private int BindSqlToVector()
        {
            int index = 0;
            string query = "SELECT * FROM tranzactii";
            string conString = "DataSource=D:\\fu.sqlite;Version=3";

            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
                _con.Open();
                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                using (SQLiteDataReader _rdr = _cmd.ExecuteReader())
                {

                    while (_rdr.Read())
                    {
                        int reputation = int.Parse(_rdr["reputation"].ToString());
                        string shakehands = _rdr["hands"].ToString();
                        string pay = (string)_rdr["pay"];
                        int product_id = int.Parse(_rdr["product_id"].ToString());

                        Transaction toBeAdd = new Transaction();

                        toBeAdd.Id = index + 1;
                        toBeAdd.Reputation = reputation;
                        toBeAdd.ShakeHands = shakehands;
                        toBeAdd.Product_id = product_id;
                        toBeAdd.Pay = pay;

                        transactions[index] = toBeAdd;
                        index++;
                    }
                    _con.Close();
                };
            };
            return index;
        }
        public void AddToTableTranzactii(Transaction newItem)
        {
            string query = "INSERT INTO tranzactii(id, reputation, hands, pay, product_id) VALUES" +
                            "(null, @reputation, @hands, @pay, @product_id)";
            string conString = "DataSource=D:\\fu.sqlite;Version=3;";
            using (SQLiteConnection _con = new SQLiteConnection(conString))
            {
              _con.Open();
              using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
              {
                _cmd.Parameters.AddWithValue("@reputation", newItem.Reputation);
                _cmd.Parameters.AddWithValue("@hands", newItem.ShakeHands); // shake hands = rsa double key 
                _cmd.Parameters.AddWithValue("@pay", newItem.Pay);
                _cmd.Parameters.AddWithValue("@product_id", newItem.Product_id);
                 _cmd.ExecuteNonQuery();
             };
            };
         }

        public void DeleteFromTableTranzactii(int knownId)
        {
            string query = "DELETE FROM tranzactii WHERE id = knownId";
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

        public void DropTableTranzactii()
        {
            string query = "DROP TABLE tranzactii";
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