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

    public class GetAssignedStaffDto
    {
        public string Id { get; set; }
        public GetEventDto Event { get; set; }
        public GetLocationDto Location { get; set; }
        public GetUserDto User { get; set; }
    }

    public class AssignStaffToLocationDto
    {
        public string UserId { get; set; }
        public string EventId { get; set; }
        public string LocationId { get; set; }
    }

}
