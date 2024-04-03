using Microsoft.AspNetCore.Mvc;

namespace SignalrDay1.Controllers
{
    public class chatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
