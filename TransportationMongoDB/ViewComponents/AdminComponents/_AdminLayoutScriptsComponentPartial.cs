using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.ViewComponents.AdminComponents
{
    public class _AdminLayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
