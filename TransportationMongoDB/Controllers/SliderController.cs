using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.Controllers
{
    public class SliderController : Controller
    {
        public IActionResult SliderList()
        {
            return View();
        }
    }
}
