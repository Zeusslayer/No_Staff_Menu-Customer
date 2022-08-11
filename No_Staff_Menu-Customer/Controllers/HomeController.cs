using Microsoft.AspNetCore.Mvc;

namespace No_Staff_Menu_Customer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
