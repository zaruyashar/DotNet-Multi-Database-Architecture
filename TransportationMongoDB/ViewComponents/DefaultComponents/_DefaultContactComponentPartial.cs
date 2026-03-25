using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
