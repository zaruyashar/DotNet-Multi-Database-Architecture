using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
