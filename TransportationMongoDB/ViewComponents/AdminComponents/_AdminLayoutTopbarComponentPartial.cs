using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.ViewComponents.AdminComponents
{
    public class _AdminLayoutTopbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
