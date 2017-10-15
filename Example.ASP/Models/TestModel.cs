using Example.ASP.Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Example.ASP.Libraries.DbTable;
using System.Data.Entity;
using Example.ASP.Libraries;

namespace Example.ASP.Models
{
    public class TestModel : Libraries.Singleton<TestModel>
    {
        private TestDao _dao;

        private TestModel()
        {
            this._dao = new TestDao();
        }

        public Object getAll()
        {
            List<string> aa = new List<string>();
            foreach(var a in _dao.Test)
            {
                aa.Add(a.TestName);
            }
            return aa;
        }
    }
}