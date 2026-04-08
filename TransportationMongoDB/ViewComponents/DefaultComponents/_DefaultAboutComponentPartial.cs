using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Services.AboutServices;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _DefaultAboutComponentPartial(IAboutService AboutService)
        {
            _aboutService = AboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAllAboutsAsync();
            return View(values);
        }
    }
}
