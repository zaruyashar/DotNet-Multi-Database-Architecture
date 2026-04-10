namespace TransportationMongoDB.Dtos.ShipmentTrackingDtos
{
    public class UpdateShipmentTrackingDto
    {
        public string TrackingNumber { get; set; }
        public int TrackingIndex { get; set; } 
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string TrackingStatus { get; set; }
    }
}
