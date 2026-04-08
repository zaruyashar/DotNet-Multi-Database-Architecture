using DatabaseMastery.TransportMongoDb.Services.HowItWorkServices;
using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Dtos.HowItWorkDtos;

namespace DatabaseMastery.TransportMongoDb.Controllers
{
    public class HowItWorkController : Controller
    {
        private readonly IHowItWorkService _howItWorkService;
        public HowItWorkController(IHowItWorkService HowItWorkService)
        {
            _howItWorkService = HowItWorkService;
        }
        public async Task<IActionResult> HowItWorkList()
        {
            var values = await _howItWorkService.GetAllHowItWorkAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateHowItWork()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateHowItWork(CreateHowItWorkDto createHowItWorkDto)
        {
            await _howItWorkService.CreateHowItWorkAsync(createHowItWorkDto);
            return RedirectToAction("HowItWorkList");
        }

        public async Task<IActionResult> DeleteHowItWork(string id)
        {
            await _howItWorkService.DeleteHowItWorkAsync(id);
            return RedirectToAction("HowItWorkList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateHowItWork(string id)
        {
            var value = await _howItWorkService.GetHowItWorkByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateHowItWork(UpdateHowItWorkDto updateHowItWorkDto)
        {
            await _howItWorkService.UpdateHowItWorkAsync(updateHowItWorkDto);
            return RedirectToAction("HowItWorkList");
        }
    }
}
