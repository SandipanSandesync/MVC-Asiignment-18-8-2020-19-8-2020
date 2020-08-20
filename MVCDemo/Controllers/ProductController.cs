using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var product = GetProduct();
            return View(product);
        }
        public IEnumerable<Product>GetProduct()
        {
            return new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Rate=100.01 },
                new Product{Id=2,Name="Keyboard",Rate=200.01 },
                new Product{Id=3,Name="Laptop",Rate=10000.01 },
                new Product{Id=4,Name="Pendrive",Rate=150.01 },
            };
        }
        public ActionResult Details(int id)
        {
            var product = GetProduct().SingleOrDefault(c => c.Id == id);
            if (product == null)
                return HttpNotFound();
            else
                return View(product);
        }
    }
}