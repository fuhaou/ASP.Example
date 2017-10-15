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
        /**
         * NOTE: Default Database Access Object
         * DbSet<???> ??? { get; set; } 
         * Replace the ??? with the coresponding DTO (Data transfer Object)
         */
        public DbSet<Dto.Test> Test { get; set; }
        public TestDao() : base("DatabaseConnection") { }

        /* Custom Function */

        public IQueryable<Dto.Test> getAll()
        {
            return this.Test;
        }

        public IQueryable<Dto.Test> searchQuery(string Name)
        {
            var select = this.Test.Where(item => item.TestName.Contains("Name"));
            return select;
        }
    }
}