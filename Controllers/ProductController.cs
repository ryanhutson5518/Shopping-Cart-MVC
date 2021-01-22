using ecommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly List<ProductModel> _products = JsonConvert.DeserializeObject<List<ProductModel>>(System.IO.File.ReadAllText(@"Data\Data.json"));

        public IActionResult Index()
        {
            return View(_products);
        }

        public IActionResult ViewProduct(ProductModel product)   // This action takes in the single product from index ^. I can then send it to another view and do whatever I would like with the data.
        {
            var obj = _products[product.ID - 1];
            return View(obj);
        }
    }
}
