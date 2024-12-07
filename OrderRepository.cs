using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceApp.Repsoitories
{
    public class OrderRepository : IOrderRepository
    {
        private OnlineECommContext _Context1;
        public OrderRepository()
        {
            _Context1 = new OnlineECommContext();
        }
        public void AddOrder(Order order)
        {
            try
            {
                order.OrderDate = DateTime.Now;
                _Context1.Orders.Add(order);
                _Context1.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteOrder(string orderid)
        {
            try
            {
                var order1 = _Context1.Orders.SingleOrDefault(x => x.OrderId == orderid);
                _Context1.Orders.Remove(order1);
                _Context1.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Order> GetAll()
        {
            try
            {
                return _Context1.Orders.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Order GetOrderById(string id)
        {
            try
            {
                var order = _Context1.Orders.SingleOrDefault(x=>x.OrderId==id);
                return order;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Order> GetOrdersByProduct(string productid)
        {
            var order=_Context1.Orders.Where(x=>x.ProductId==productid).ToList();
            return order;
        }
    }
}