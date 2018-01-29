using GetHashAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GetHashAPI
{
    class HashContext : DbContext
    {
        public DbSet<Hash> Hashes { get; set; }

    }
}