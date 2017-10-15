using Example.ASP.Libraries;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Example.ASP.Models.Dao
{
    public class TestDao : DbContext
    {
        public DbSet<Libraries.DbTable.Test> Test { get; set; }
        public TestDao() : base("DatabaseConnection") { }
    }
}