using System.ComponentModel.DataAnnotations;

namespace ParvigateUI.DTOs
{
    public class AddConnectionDto
    {
        [Required]
        public string SourceLocationId { get; set; }

        [Required]
        public string DestinationLocationId { get; set; }
        public double DistanceInKm { get; set; }
        public double AverageSpeed { get; set; }
    }
}
