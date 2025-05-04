using MVC_Projec2.Models;

public class DashboardViewModel
{
    public int TotalUsers { get; set; }
    public int TotalHalls { get; set; }
    public int TotalSessions { get; set; }
    public int TotalMakeUpServices { get; set; }
    public int TotalBookings { get; set; }
    public int TotalAteliers { get; set; }
    public int TotalDecores { get; set; }
    public decimal Revenue { get; set; }
    public string MostBookedVenue { get; set; }
    public List<Booking> RecentBookings { get; set; } = new List<Booking>();

    // Formatted properties for display
    public string FormattedRevenue => Revenue.ToString("C");
    public string LastUpdated => DateTime.Now.ToString("g");
}