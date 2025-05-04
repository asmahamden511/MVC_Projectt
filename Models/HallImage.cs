namespace MVC_Projec2.Models
{
    public class HallImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
    }
}
