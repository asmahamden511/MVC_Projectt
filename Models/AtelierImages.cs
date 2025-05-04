namespace MVC_Projec2.Models
{
    public class AtelierImages
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int AtelierId { get; set; }
        public Atelier Atelier { get; set; }

    }
}
