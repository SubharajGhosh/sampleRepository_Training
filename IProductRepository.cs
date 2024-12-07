using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Repsoitories
{
    internal interface IProductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
        Product Get(string id);
        void Edit(Product product);
        void Delete(string id);

    }
}
