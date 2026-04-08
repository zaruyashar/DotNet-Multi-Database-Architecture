using DatabaseMastery.TransportMongoDb.Services.HowItWorkServices;
using Microsoft.AspNetCore.Mvc;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultHowItWorksComponentPartial : ViewComponent
    {
        private readonly IHowItWorkService _howItWorkService;
        public _DefaultHowItWorksComponentPartial(IHowItWorkService HowItWorkService)
        {
            _howItWorkService = HowItWorkService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _howItWorkService.GetAllHowItWorkAsync();
            return View(values);
        }
    }
}
