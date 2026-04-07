using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Dtos.BrandDtos;
using TransportationMongoDB.Services.BrandServices;

namespace TransportationMongoDB.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _BrandService;

        public BrandController(IBrandService BrandService)
        {
            _BrandService = BrandService;
        }

        public async Task<IActionResult> BrandList()
        {
            var values = await _BrandService.GetAllBrandsAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateBrand()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandDto createBrandDto)
        {
            await _BrandService.CreateBrandAsync(createBrandDto);
            return RedirectToAction("BrandList");
        }

        public async Task<IActionResult> DeleteBrand(string id)
        {
            await _BrandService.DeleteBrandAsync(id);
            return RedirectToAction("BrandList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBrand(string id)
        {
            var value = await _BrandService.GetBrandByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBrand(UpdateBrandDto updateBrandDto)
        {
            await _BrandService.UpdateBrandAsync(updateBrandDto);
            return RedirectToAction("BrandList");
        }
    }
}
