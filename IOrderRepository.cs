using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Repsoitories
{
    internal interface IOrderRepository
    {
        void AddOrder(Order order);
        List<Order> GetAll();
        Order GetOrderById(string orderid);
        void DeleteOrder (string orderid);
    }
}
