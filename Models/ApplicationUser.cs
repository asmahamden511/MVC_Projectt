using Microsoft.AspNetCore.Identity;

namespace MVC_Projec2.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? FullName { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<Booking>? Bookings { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
