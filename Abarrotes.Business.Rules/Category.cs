using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abarrotes.DataAccess;
using Abarrotes.Interface;
using Abarrotes.Business.Core;

namespace Abarrotes.Business.Rules
{
    public class BusinessCategory : ICategory
    {
        private readonly MySQLiteContext _contextConnection;
        private readonly CoreCategory _category;

        public BusinessCategory(MySQLiteContext context)
        {
            _contextConnection = context;
            _category = new CoreCategory(_contextConnection);
        }

        public string Add(Category category)
        {
            try
            {
                return _category.Add(category);
            }
            finally
            {
                this._category.Dispose();
            }            
        }

        public string Delete(int id)
        {
            try
            {
                return _category.Delete(id);
            }
            finally
            {
                _category.Dispose();
            }
        }

        public IEnumerable<Category> GetAll()
        {
            try
            {
                return _category.GetAll();
            }
            finally
            {
                _category.Dispose();
            }
        }

        public Category GetById(int id)
        {
            try
            {
                return _category.GetById(id);
            }
            finally
            {
                _category.Dispose();
            }
        }

        public Category Find(string name)
        {
            try
            {
                return _category.Find(name);
            }
            finally
            {
                _category.Dispose();
            }
        }

        public string Update(Category category)
        {
            try
            {
                return _category.Update(category);
            }
            finally
            {
                _category.Dispose();
            }
        }
    }
}
