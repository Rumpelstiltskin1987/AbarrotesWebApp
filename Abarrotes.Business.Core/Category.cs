using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Abarrotes.DataAccess;
using Abarrotes.Interface;
using Microsoft.CodeAnalysis.Text;
using Microsoft.EntityFrameworkCore;

namespace Abarrotes.Business.Core
{
    public class CoreCategory : BusinessRules, ICategory
    {
        public CoreCategory(MySQLiteContext context) 
            : base(context) 
        { 
        }

        public string Add(Category category)
        {
            string message = string.Empty;

            try
            {
                category.Status = "AC";
                category.CreateUser = "Alta";
                category.CreateDate = DateTime.Now;

                _contextConnection.Add(category);
                _contextConnection.SaveChanges();

                message = "Categoría registrada";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }

            return message;
        }

        public string Delete(int id)
        {
            Category category = new Category();

            string message = string.Empty;

            try
            {
                GetById(id);
                category.Status = "IN"; 
                category.LastUpdateUser = "Update";
                category.LastUpdateDate = DateTime.Now;

                _contextConnection.Update(category);
                _contextConnection.SaveChanges();

                message = "Categoria eliimnada";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }

            return message;

        }

        public IEnumerable<Category> GetAll()
        {
            IEnumerable<Category> categories = new List<Category>();

            try
            {
                categories = _contextConnection.Category
                    .Where(x => x.Status == "AC")
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categories;    
        }

        public Category GetById(int id)
        {
            Category category = new Category();

            try
            {
                category = _contextConnection.Category
                    .Where(x => x.IdCategory == id)
                    .FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }

            return category;
        }

        public Category Find(string name)
        {
            Category category = new Category();

            try
            {
                category = _contextConnection.Category.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }

            return category;
        }

        public string Update(Category category)
        {
            string message = string.Empty;

            try
            {
                category.LastUpdateUser = "Update";
                category.LastUpdateDate = DateTime.Now;

                _contextConnection.Update(category);
                _contextConnection.SaveChanges();

                message = "Categoria actualizada";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }

            return message;
        }
    }
}
