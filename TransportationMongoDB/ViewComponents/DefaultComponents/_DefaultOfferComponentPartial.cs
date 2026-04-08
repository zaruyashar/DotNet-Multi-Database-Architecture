using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Services.OfferServices;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultOfferComponentPartial : ViewComponent
    {
        private readonly IOfferService _offerService;

        public _DefaultOfferComponentPartial(IOfferService OfferService)
        {
            _offerService = OfferService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _offerService.GetAllOffersAsync();
            return View(values);
        }
    }
}
