using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.ViewComponents.AdminComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
