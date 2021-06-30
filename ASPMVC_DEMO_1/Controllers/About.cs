using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_DEMO_1.Controllers
{
    public class About : Controller
    {
        // GET
        public string Index()
        {
            return "About Us ...";
        }
    }
}