using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DB;

namespace WebApplication1.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            var suppliers = InMemoryDB.Suppliers;
            return View(suppliers);
        }

    }
}
