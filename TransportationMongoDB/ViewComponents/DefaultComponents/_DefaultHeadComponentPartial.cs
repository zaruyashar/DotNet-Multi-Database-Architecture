using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
