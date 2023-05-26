using System.ComponentModel.DataAnnotations;

namespace ParvigateUI.DTOs
{
    public class AddLocationDto
    {
        [Required]
        public string LocationType { get; set; }

        [Required]
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        [Required]
        public string Name { get; set; }


        public int SpaceCount { get; set; }
    }


    public class GetConnectionDto
    {
        public string Id { get; set; }
        public GetLocationDto SourceLocation { get; set; }
        public GetLocationDto DestinationLocation { get; set; }
        public double DistanceInKm { get; set; }
        public double AverageSpeed { get; set; }
    }

    public class GetLocationDto
    {
        public string Id { get; set; }
        public string LocationType { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Name { get; set; }
        public int SpaceCount { get; set; }
    }

    public class AddLocationTagDto
    {
        [Required]
        public string LocationId { get; set; }

        [Required]
        public string TagId { get; set; }

        [Required]
        public string UserName { get; set; }
    }

    public class UpdateLocationTagDto
    {
        public string LocationId { get; set; }

        public string TagId { get; set; }

        public string UserName { get; set; }
    }

    public class GetLocationTagDto
    {
        public string Id { get; set; }
        public GetLocationDto Location { get; set; }

        public GetTagDto Tag { get; set; }

        public string UserName { get; set; }

        public List<GetParkingRecordDto> Records { get; set; }
    }

    public class GetTagDto
    {
        public string Id { get; set; }
        public string SerialNumber { get; set; }
    }

    public class GetParkingRecordDto
    {
        public DateTime ArrivalTime { get; set; }
        public DateTime? CheckInTime { get; set; }

        public DateTime? DepartureTime { get; set; }
        public DateTime? CheckoutTime { get; set; }
    }

    public class ErrorItemModel
    {
        public string Key { get; set; }
        public List<string> ErrorMessages { get; set; }
    }

    public class GlobalResponse<T>
    {
        public T Data { get; set; }
        public List<ErrorItemModel> Errors { get; set; }

        public GlobalResponse()
        {
            Errors = new List<ErrorItemModel>();
        }
    }
}
