using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Quotes_Api.Models;


namespace Quotes_Api.Data
{
    public class QuotesDbContext : DbContext
    {
        public DbSet<Quotes> Quotes { get; set; }
    }
}