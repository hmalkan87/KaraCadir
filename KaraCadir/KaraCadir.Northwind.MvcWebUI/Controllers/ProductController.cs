using KaraCadir.Northwind.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaraCadir.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        //private IProductService _productService;
        
        public ActionResult Index()
        {
            return View();
        }
    }
}
