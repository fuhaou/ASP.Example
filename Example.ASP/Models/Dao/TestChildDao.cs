using Example.ASP.Libraries;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Example.ASP.Models.Dao
{ 
    public class TestChildDao : DbContext
    {
        public DbSet<Dto.TestChild> TestChild { get; set; }
        public TestChildDao() :base("DatabaseConnection") { }
    }
}