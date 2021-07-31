using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DB;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        //public ProductController()
        //{
        //    var products = InMemoryDB.Products;
        //}
        List<Product> products = InMemoryDB.Products;
        public IActionResult Index()
        {

            return View(products);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Parameter name in view and action must be the same. It is safer to use <a> tag like  <a href="/Product/Edit/@item.ProductId">Edit</a> as it doesn't use a parameter name.
            //index = InMemoryDB.Products.FindIndex(p => p.Equals(model));
            var model = InMemoryDB.Products.FirstOrDefault(p => p.ProductId.Equals(id));
            //if (model == null)
            //{
            //    return RedirectToAction("Index");
            //}
            return View(model);
        }

        #region create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            InMemoryDB.Products.Add(model);
            return RedirectToAction("Index");
        }

        #endregion
    }
}
