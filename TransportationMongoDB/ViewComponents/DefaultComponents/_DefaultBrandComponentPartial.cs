using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Services.BrandServices;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultBrandComponentPartial : ViewComponent
    {
        private readonly IBrandService _BrandService;

        public _DefaultBrandComponentPartial(IBrandService BrandService)
        {
            _BrandService = BrandService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _BrandService.GetAllBrandsAsync();
            return View(values);
        }
    }
}
