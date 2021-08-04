using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DB;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            var suppliers = InMemoryDB.Suppliers;
            return View(suppliers);
        }

        #region create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Supplier model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            InMemoryDB.Suppliers.Add(model);
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        [HttpGet]
        public ActionResult Delete(int id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return RedirectToAction("Index");
            //}
            Supplier supplierToDelete = InMemoryDB.Suppliers.FirstOrDefault(s => s.Id.Equals(id));
            return View(supplierToDelete);
        }

        [HttpPost]
        public ActionResult Delete(int supplierId, Supplier supplier)
        {
            int index = InMemoryDB.Suppliers.FindIndex(s => s.Id.Equals(supplier.Id));
            if(index > -1)
            {
                InMemoryDB.Suppliers.RemoveAt(index);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int supplierId)
        {
            int index = InMemoryDB.Suppliers.FindIndex(s => s.Id.Equals(supplierId));
            if(index > -1)
            {
                return View(InMemoryDB.Suppliers[index]);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Supplier supplier)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            int index = InMemoryDB.Suppliers.FindIndex(s => s.Id.Equals(supplier.Id));
            InMemoryDB.Suppliers[index] = supplier;
            return RedirectToAction("Index");
        }

        #endregion

        #region Detail
        [HttpGet]
        public IActionResult Detail(int id)
        {
            int index = InMemoryDB.Suppliers.FindIndex(s => s.Id.Equals(id));
            return View(InMemoryDB.Suppliers[index]);
        }
        #endregion
    }
}
