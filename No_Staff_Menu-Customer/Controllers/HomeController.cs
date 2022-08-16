using Microsoft.AspNetCore.Mvc;
using No_Staff_Menu_Customer.API;
using No_Staff_Menu_Customer.Models;

namespace No_Staff_Menu_Customer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Send(OrderModel order) {
            Api.sendOrder(order);
            return BadRequest();
        }
    }
}
