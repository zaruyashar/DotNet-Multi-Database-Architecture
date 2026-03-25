using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.ViewComponents.AdminComponents
{
    public class _AdminLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
