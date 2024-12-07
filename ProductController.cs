using ECommerceApp.Repsoitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceApp.Entities;

namespace ECommerceApp.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository productRepository;
        public ProductController() 
        { 
            productRepository = new ProductRepository();
        }
        // GET: Product
        public ActionResult Index()
        {
            var products = productRepository.GetAll();
            return View(products);
        }
        public ActionResult Details(string id)
        {
            var product = productRepository.Get(id);
            return View(product);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            productRepository.Add(product);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string id) 
        {
            var product= productRepository.Get(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productRepository.Edit(product);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            productRepository.Delete(id);
            return RedirectToAction("Index");   
        }
       
    }
}