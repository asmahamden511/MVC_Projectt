namespace MVC_Projec2.Models
{
    public class SessionImages
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}
