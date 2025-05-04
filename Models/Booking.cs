using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Projec2.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Hall")]
        public int? Hall_Id { get; set; }

        [ForeignKey("Session")]
        public int? Session_Id { get; set; }

        [ForeignKey("Atelier")]
        public int? Atelier_Id { get; set; }

        [ForeignKey("MakeUp_Service")]
        public int? MakeupId { get; set; }

        [ForeignKey("Decor")]
        public int? Decor_Id { get; set; }

       
        [ForeignKey("user")]
        public string? user_id { get; set; }
        public string ?Status { get; set; }
        public DateTime Created_at { get; set; }


        
        public virtual ApplicationUser? user { get; set; }
        public virtual Hall ?Hall { get; set; }
        public virtual Session? Session { get; set; }
        public virtual Atelier ?Atelier { get; set; }
        public virtual MakeUp_Service? MakeUp { get; set; }
        public virtual Decor? Decor { get; set; }
    }
}
