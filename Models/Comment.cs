using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Projec2.Models
{

    public enum ServiceType
    {
        Hall,
        Session,
        Atelier,
        MakeUp,
        Decor
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        public int ServiceId { get; set; }
        public ServiceType ServiceType { get; set; }
    }

}
