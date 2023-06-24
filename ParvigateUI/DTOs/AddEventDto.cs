using System.ComponentModel.DataAnnotations;

namespace ParvigateUI.DTOs
{
    public class AddEventDto
    {
        [Required(ErrorMessage = "please provide an event name")]
        public string EventName { get; set; }


        [Required(ErrorMessage = "Date must be provided")]
        public DateTime EventDate { get; set; } = DateTime.UtcNow;
    }


    public enum EventStatus
    {
        NotYetStarted,
        InProgress,
        Completed
    }
}
