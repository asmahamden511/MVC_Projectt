namespace MVC_Projec2.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public List<SessionImages> Images { get; set; } = new List<SessionImages>();
        public string? ImageUrl { get; set; }
        public string? Location { get; set; }
        public double? Price { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}
