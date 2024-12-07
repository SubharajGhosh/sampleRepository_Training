using ECommerceApp.Entities;
using ECommerceApp.Repsoitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceApp.Controllers
{
    public class OrderController : Controller
    {
        private OrderRepository orderRepository;
        public OrderController()
        {
            orderRepository = new OrderRepository();
        }
        // GET: Order
        public ActionResult Index()
        {
            var orders = orderRepository.GetAll();
            return View(orders);
        }
        public ActionResult Details(string id)
        {
            var order = orderRepository.GetOrderById(id);
            return View(order);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Order order)
        {
            orderRepository.AddOrder(order);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            orderRepository.DeleteOrder(id);
            return RedirectToAction("Index");
        }
        public ActionResult GetOrders(string id)
        {
            var filtered = orderRepository.GetOrdersByProduct(id);
            return View(filtered);
        }

    }
}