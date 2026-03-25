using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
