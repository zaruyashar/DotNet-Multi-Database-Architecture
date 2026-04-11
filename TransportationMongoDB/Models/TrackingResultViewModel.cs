namespace TransportationMongoDB.Models
{
    public class TrackingResultViewModel
    {
        public string TrackingNumber { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public string OriginCity { get; set; }
        public string OriginDistrict { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationDistrict { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CurrentStatus { get; set; }
        public List<TrackingEventViewModel> Events { get; set; } = new();

        // Geçerli duruma göre progress bar'daki adım index'i (0-4)
        public int CurrentStepIndex => CurrentStatus switch
        {
            "Gönderi Alındı" => 0,
            "Transfer Merkezinde" => 1,
            "Yolda" => 2,
            "Dağıtımda" => 3,
            "Teslim Edildi" => 4,
            _ => 0
        };

        public bool IsDelivered => CurrentStatus == "Teslim Edildi";
    }
}
