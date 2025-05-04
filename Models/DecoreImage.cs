namespace MVC_Projec2.Models
{
    public class DecoreImage
    {
            public int Id { get; set; }
            public string ImageUrl { get; set; }
            public int DecorId { get; set; }
            public Decor Decor { get; set; }
        
    }
}
