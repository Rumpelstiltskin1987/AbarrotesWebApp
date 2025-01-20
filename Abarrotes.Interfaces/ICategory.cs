using Abarrotes.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.Interface
{
    public interface ICategory
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        Category Find(string name);
        string Add(Category category);
        string Update(Category category);
        string Delete(int id); 
    }
}
