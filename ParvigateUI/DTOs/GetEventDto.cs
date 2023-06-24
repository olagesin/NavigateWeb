namespace ParvigateUI.DTOs
{
    public class GetEventDto
    {
        public string Id { get; set; }
        public string EventName { get; set; }

        public DateTime EventDate { get; set; }
        public string EventStatus { get; set; }
    }

    //public class GetUserDto
    //{
    //    public string Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string RoleName { get; set; }
    //    public string Email { get; set; }
    //}
}
