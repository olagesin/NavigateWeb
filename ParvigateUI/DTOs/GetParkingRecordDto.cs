namespace ParvigateUI.DTOs
{
    public class GetParkingRecordDto
    {
        public DateTime ArrivalTime { get; set; }
        public DateTime? CheckInTime { get; set; }

        public DateTime? DepartureTime { get; set; }
        public DateTime? CheckoutTime { get; set; }

        public string TagSerialNumber { get; set; }

        public GetEventDto Event { get; set; }

        public GetLocationDto Location { get; set; }
    }
}
