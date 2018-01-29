using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetHashAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int Reputation { get; set; }
        public string ShakeHands { get; set; }
        public string Pay { get; set; }
        public string RSAPublicKey { get; set; }
        public int Product_id { get; set; }
    }
}