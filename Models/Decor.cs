namespace MVC_Projec2.Models
{
    public class Decor
    {
        public int Id { get; set; }
        public string Style { get; set; }
        public string? ImageUrl { get; set; }
        public int Price { get; set; }
        public string ?Description { get; set; }
        public List<DecoreImage> Images { get; set; } = new List<DecoreImage>();

    }
}
