using System.ComponentModel.DataAnnotations;

namespace ParvigateUI.DTOs
{
    public class GetTagDto
    {
        public string Id { get; set; }
        public string SerialNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public class AddUserDto
    {
        [Required(ErrorMessage = "First name is required")]
        [StringLength(30, ErrorMessage = "Name can be no larger than 30 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(30, ErrorMessage = "Name can be no larger than 30 characters")]
        public string LastName { get; set; }

        [Required]
        public string RoleName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
