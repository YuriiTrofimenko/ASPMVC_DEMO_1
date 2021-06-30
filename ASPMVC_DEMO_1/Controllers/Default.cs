using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_DEMO_1.Controllers
{
    public class Default : Controller
    {
        // GET
        public ViewResult Index()
        {
            ViewBag.Title = "ASP MVC Demo 1";
            ViewBag.Content = "Default Page";
            return View();
        }
    }
}