using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetHashAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Wallet { get; set; }
        public int Reputation { get; set; }
    }
}