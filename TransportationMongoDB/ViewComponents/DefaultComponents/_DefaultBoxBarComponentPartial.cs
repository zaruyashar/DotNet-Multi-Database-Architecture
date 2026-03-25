using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultBoxBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
