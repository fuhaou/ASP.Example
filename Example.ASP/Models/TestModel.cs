using Example.ASP.Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using Example.ASP.Libraries;
using System.Web;
using System.Data.Entity;
using Example.ASP.Models;

namespace Example.ASP.Models
{
    public class TestModel : Singleton<TestModel>
    {
        private TestDao _dao;

        private TestModel()
        {
            this._dao = new TestDao();
        }
        
        public List<Dto.Test> getAll()
        {
            var result = this._dao.getAll().ToList<Dto.Test>() ?? null;
            return result;
        }

        public List<Dto.Test> searchQuery(string Name)
        {
            Name = Name.Trim();
            var result = this._dao.searchQuery(Name).ToList<Dto.Test>() ?? null;
            return result;
        }

        public string insert(string Name)
        {
            string message = null;
            try
            {
                var dataInsert = new Dto.Test()
                {
                    TestName = Name,
                    TestDate = DateTime.Now,
                    TestChild = null
                };
                this._dao.Test.Add(dataInsert);
                this._dao.SaveChanges();
            } catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }

        public string update(int Id, string Name, DateTime Date, Dto.TestChild Child)
        {
            string message = null;
            try
            {
                var dataUpdate = this._dao.Test.Find(Id);
                dataUpdate.TestName = Name;
                dataUpdate.TestDate = Date;
                dataUpdate.TestChild = Child;
                this._dao.SaveChanges();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }
    }
}