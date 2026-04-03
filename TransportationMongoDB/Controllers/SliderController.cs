using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Dtos.SliderDtos;
using TransportationMongoDB.Services.SliderServices;

namespace TransportationMongoDB.Controllers
{
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IActionResult> SliderList()
        {
            var values = await _sliderService.GetAllSlidersAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto createSliderDto)
        {
            await _sliderService.CreateSliderAsync(createSliderDto);
            return RedirectToAction("SliderList");
        }

        public async Task<IActionResult> DeleteSlider(string id)
        {
            await _sliderService.DeleteSliderAsync(id);
            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSlider(string id)
        {
            var value = await _sliderService.GetSliderByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            await _sliderService.UpdateSliderAsync(updateSliderDto);
            return RedirectToAction("SliderList");
            return RedirectToAction("SliderList");
        }
    }
}
