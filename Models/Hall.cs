namespace MVC_Projec2.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string? Location { get; set; }
        public double ?Price { get; set; }

        public string ?ImageUrl { get; set; }



        public List<HallImage> Images { get; set; } = new List<HallImage>();

    }
}
