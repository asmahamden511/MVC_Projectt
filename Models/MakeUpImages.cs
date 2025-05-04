namespace MVC_Projec2.Models
{
    public class MakeUpImages
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int MakeUp_ServiceId { get; set; }
        public MakeUp_Service makeUp { get; set; }
    }
}
