namespace ParvigateUI.DTOs
{
    public class GetLocationDto
    {
        public string Id { get; set; }
        public string LocationType { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Name { get; set; }
        public int SpaceCount { get; set; }
    }
}
