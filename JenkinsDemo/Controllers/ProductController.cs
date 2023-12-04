using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JenkinsDemo.Models;
namespace JenkinsDemo.Controllers
{
    public class ProductController : Controller
    {
        
        // GET: Product
        public ActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            productModel.ProductId = 1;
            productModel.ProductName = "Test";
            return View();
        }
    }
}