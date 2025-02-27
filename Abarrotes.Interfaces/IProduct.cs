﻿using Abarrotes.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        IEnumerable<Product> Find(Expression<Product> exp);
        string Add(Product product);
        string Update(Product product);
        string Delete(int id);
    }
}
