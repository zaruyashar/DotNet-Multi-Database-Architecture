using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Services.TestimonialService;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _DefaultTestimonialComponentPartial(ITestimonialService TestimonialService)
        {
            _testimonialService = TestimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetAllTestimonialsAsync();
            return View(values);
        }
    }
}
