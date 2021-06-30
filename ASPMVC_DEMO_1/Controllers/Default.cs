using ASPMVC_DEMO_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_DEMO_1.Controllers
{
    public class Default : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            ViewBag.Title = "ASP MVC Demo 1";
            ViewBag.Content = "Default Page";
            return View(new Product(){Id = 1, Name = "Windows11", Price = 100500});
        }
        
        [HttpPost]
        // [Route("[controller]/[action]")]
        public ViewResult Add(/* [FromBody] */Product product)
        {
            product.Id = 2;
            return View("Index", product);
        }
    }
}