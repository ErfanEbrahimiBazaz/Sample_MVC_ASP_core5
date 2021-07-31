using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DB;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var categories = InMemoryDB.Categories;
            return View(categories);
        }

        #region Edit

        [HttpGet]
        public ActionResult Edit(int categoryId)
        {
            var category = InMemoryDB.Categories.FirstOrDefault(c => c.CategoryId.Equals(categoryId));
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }

        //When there is already a method with similar name and [HttpGet] tag, the other method by default becomes [HttpPost].
        //[HttpPost]
        public IActionResult Edit(Category category)
        {
            int index = InMemoryDB.Categories.FindIndex(c => c.CategoryId.Equals(category.CategoryId));
            if (index > -1)
            {
                InMemoryDB.Categories[index] = category;
                return RedirectToAction("Index");
            }
            return View(category);
        }
        #endregion

        #region Delete
        [HttpGet]
        public ActionResult Delete(int categoryId)
        {
            int index = -1;
            index = InMemoryDB.Categories.FindIndex(c => c.CategoryId.Equals(categoryId));
            if (index > -1)
            {
                var model = InMemoryDB.Categories[index];
                return View(model);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int categoryId, Category category)
        {
            int index = InMemoryDB.Categories.FindIndex(c => c.CategoryId.Equals(categoryId));
            if (index > -1)
            {
                InMemoryDB.Categories.RemoveAt(index);
                return RedirectToAction("Index");
            }

            //return View(InMemoryDB.Categories[index]);
            return RedirectToAction("Index");
        }


        //[HttpGet]
        //public ActionResult Delete(int categoryId)
        //{
        //    int index = InMemoryDB.Categories.FindIndex(c => c.CategoryId.Equals(categoryId));
        //    if (index > -1)
        //    {
        //        InMemoryDB.Categories.RemoveAt(index);
        //        return RedirectToAction("Index");
        //    }

        //    return View(InMemoryDB.Categories[index]);
        //}

        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            InMemoryDB.Categories.Add(model);
            return RedirectToAction("Index");
        }

        #endregion

        #region Details
        [HttpGet]
        //Action Details is waiting for an input coming from view with the name categoryId. Therefore, the name of the parameter is very important and must be the same both at
        //action and view.
        public ActionResult Details(int categoryId)
        {
            var model = InMemoryDB.Categories.FirstOrDefault(c => c.CategoryId.Equals(categoryId));
            return View(model);
        }
        #endregion

    }
}
