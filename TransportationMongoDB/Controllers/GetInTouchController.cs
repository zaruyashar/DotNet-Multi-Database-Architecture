using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Dtos.GetInTouchDtos;
using TransportationMongoDB.Services.GetInTouchService;

namespace TransportationMongoDB.Controllers
{
    public class GetInTouchController : Controller
    {
        private readonly IGetInTouchService _getInTouchService;

        public GetInTouchController(IGetInTouchService GetInTouchService)
        {
            _getInTouchService = GetInTouchService;
        }

        public async Task<IActionResult> GetInTouchList()
        {
            var values = await _getInTouchService.GetAllGetInTouchsAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateGetInTouch()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGetInTouch(CreateGetInTouchDto createGetInTouchDto)
        {
            await _getInTouchService.CreateGetInTouchAsync(createGetInTouchDto);
            return RedirectToAction("GetInTouchList");
        }

        public async Task<IActionResult> DeleteGetInTouch(string id)
        {
            await _getInTouchService.DeleteGetInTouchAsync(id);
            return RedirectToAction("GetInTouchList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateGetInTouch(string id)
        {
            var value = await _getInTouchService.GetGetInTouchByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateGetInTouch(UpdateGetInTouchDto updateGetInTouchDto)
        {
            await _getInTouchService.UpdateGetInTouchAsync(updateGetInTouchDto);
            return RedirectToAction("GetInTouchList");
        }
    }
}
