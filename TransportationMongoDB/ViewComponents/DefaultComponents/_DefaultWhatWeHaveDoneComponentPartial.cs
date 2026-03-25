using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultWhatWeHaveDoneComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
