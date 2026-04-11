using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Services.ShipmentServices;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultStatisticsComponentPartial : ViewComponent
    {
        private readonly IShipmentService _shipmentService;

        public _DefaultStatisticsComponentPartial(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }

        public async Task <IViewComponentResult> InvokeAsync()
        {
            ViewBag.v1 = await _shipmentService.GetTotalShipmentCountAsync();
            ViewBag.v2 = await _shipmentService.GetDeliveredShipmentCountAsync();
            ViewBag.v3 = await _shipmentService.GetDistinctDestinationCityCountAsync();
            ViewBag.v4 = await _shipmentService.GetInDistributionShipmentCountAsync();
            return View();
        }
    }
}
