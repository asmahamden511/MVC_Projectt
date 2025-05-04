namespace MVC_Projec2.ViewModels
{
    public class BookingViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string HallName { get; set; }
        public string SessionDuration { get; set; }
        public string AtelierName { get; set; }
        public string MakeupService { get; set; }
        public string DecorStyle { get; set; }
        public string SessionType { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
