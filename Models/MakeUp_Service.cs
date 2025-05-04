namespace MVC_Projec2.Models
{
    public class MakeUp_Service
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public List<MakeUpImages> Images { get; set; } = new List<MakeUpImages>();

    }
}
