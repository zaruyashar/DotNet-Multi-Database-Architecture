using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Services.SliderServices;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _DefaultSliderComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _sliderService.GetAllSlidersAsync();
            return View(values);
        }
    }
}
