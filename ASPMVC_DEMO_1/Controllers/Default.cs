using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_DEMO_1.Controllers
{
    public class Default : Controller
    {
        // GET
        public ViewResult Index()
        {
            return View();
        }
    }
}