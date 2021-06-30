using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_DEMO_1.Controllers
{
    public class Default : Controller
    {
        // GET
        public string Index()
        {
            return "Hello ASP.NET MVC!";
        }
    }
}