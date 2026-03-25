using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
