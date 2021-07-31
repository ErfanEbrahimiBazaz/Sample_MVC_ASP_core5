using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DB;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = InMemoryDB.Customers;
            return View(model);
        }

        #region Edit

        [HttpGet]
        public ActionResult Edit(int customerId)
        {
            Customer customer = InMemoryDB.Customers.FirstOrDefault(c => c.CustomerId.Equals(customerId));
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            int index = InMemoryDB.Customers.FindIndex(c => c.CustomerId.Equals(customer.CustomerId));
            if (index > -1)
            {
                InMemoryDB.Customers[index] = customer;
                return RedirectToAction("Index");
            }
            return View();
        }

        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            InMemoryDB.Customers.Add(customer);
            return RedirectToAction("Index");
        }
        #endregion

        #region Details
        [HttpGet]
        public IActionResult Details(int customerId)
        {
            Customer customer = InMemoryDB.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            return View(customer);
        }
        #endregion

        #region Delete
        [HttpGet]
        public IActionResult Delete(int customerId)
        {
            Customer customer = InMemoryDB.Customers.FirstOrDefault(c => c.CustomerId.Equals(customerId));
            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(int customerId, Customer customer)
        {
            int index = InMemoryDB.Customers.FindIndex(c => c.CustomerId.Equals(customerId));
            if (index > -1)
            {
                InMemoryDB.Customers.RemoveAt(index);
                return RedirectToAction("Index");
            }
            return View();
        }

        #endregion
    }
}
