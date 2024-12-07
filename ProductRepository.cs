using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceApp.Repsoitories
{
    public class ProductRepository : IProductRepository
    {
        private OnlineECommContext _Context;
        public ProductRepository()
        {
            _Context = new OnlineECommContext();
        }
        
        public void Add(Product product)
        {
            try
            {
                _Context.Products.Add(product);
                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(string id)
        {
            try
            {
                var product = _Context.Products.FirstOrDefault(x => x.ProductId == id);
                _Context.Products.Remove(product);
                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(Product product)
        {
            try
            {
                var obj = _Context.Products.FirstOrDefault(x => x.ProductId == product.ProductId);
                obj.Price = product.Price;
                obj.Stock = product.Stock;
                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product Get(string id)
        {
            try
            {
                var product = _Context.Products.Find(id);
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                return _Context.Products.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}