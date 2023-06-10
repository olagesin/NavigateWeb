namespace ParvigateUI.DTOs
{
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
