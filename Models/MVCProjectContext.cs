using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace MVC_Projec2.Models
{
    public class MVCProjectContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private readonly IConfiguration _configuration;

        public MVCProjectContext(DbContextOptions<MVCProjectContext> options,
                                 IConfiguration configuration): base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Atelier> Ateliers { get; set; }
        public DbSet<Decor> Decors { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<MakeUp_Service> MakeUpServices { get; set; }
        public DbSet<HallImage> HallImages { get; set; }
        public DbSet<DecoreImage> DecoreImages { get; set; }
        public DbSet<DecoreImage> AtelierImages { get; set; }
        public DbSet<DecoreImage> SessionImages { get; set; }
        public DbSet<DecoreImage> MakeUpImages { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new ApplicationRole { Id = "2", Name = "User", NormalizedName = "USER" }
            );

            var adminUserId = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = adminUserId,
                    UserName = "admin@example.com",
                    NormalizedUserName = "ADMIN@EXAMPLE.COM",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@1234!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "0123456789",
                    PhoneNumberConfirmed = true
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = adminUserId, RoleId = "1" }
            );


            var normalUserId = Guid.NewGuid().ToString();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = normalUserId,
                    UserName = "user@example.com",
                    NormalizedUserName = "USER@EXAMPLE.COM",
                    Email = "user@example.com",
                    NormalizedEmail = "USER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "User@1234!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "9876543210",
                    PhoneNumberConfirmed = true
                }
            );

           
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = normalUserId, RoleId = "2" }
            );


            modelBuilder.Entity<Booking>().HasData(
                new Booking
            {
                Id = 1,
                user_id = adminUserId,
                MakeupId = 1,
                Hall_Id = 2,
                Session_Id = 2,
                Decor_Id = 1,
                Atelier_Id = 3,
                Status = "Confirmed",
                Created_at = DateTime.Now
            },
                new Booking
                {
                    Id = 2,
                    user_id = adminUserId,
                    MakeupId = 4,
                    Hall_Id = 1,
                    Session_Id = 1,
                    Decor_Id = 2,
                    Atelier_Id = 1,
                    Status = "Pending",
                    Created_at = DateTime.Today
                });


            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    Id = 3,
                    user_id = adminUserId,
                    MakeupId = 1,
                    Hall_Id = 2,
                    Session_Id = 2,
                    Decor_Id = 1,
                    Atelier_Id = 3,
                    Status = "Confirmed",
                    Created_at = DateTime.Now
                },
                new Booking
                {
                    Id = 4,
                    user_id = adminUserId,
                    MakeupId = 4,
                    Hall_Id = 1,
                    Session_Id = 1,
                    Decor_Id = 2,
                    Atelier_Id = 1,
                    Status = "Pending",
                    Created_at = DateTime.Today
                }

            );

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    UserId = adminUserId,
                    Content = "Excellent service!",
                    CreatedAt = DateTime.Now
                }

            );

            modelBuilder.Entity<Atelier>().HasData(
                new Atelier
                {
                    Id = 1,
                    Name = "Elite Atelier",
                    ImageUrl = "atelier2.jpg",
                    Location = "Uptown",
                    priceRange = 9000
                },
                new Atelier 
                { 
                    Id = 2,
                    Name = "Royal Designs",
                    ImageUrl = "atelier1.jpg",
                    Location = "Downtown",
                    priceRange = 5000
                },
                new Atelier { 
                    Id = 3,
                    Name = "Glamorous Styles",
                    ImageUrl = "atelier5.jpg",
                    Location = "Easttown",
                    priceRange = 4000
                },
                new Atelier
                {
                    Id = 4,
                    Name = "Elegant Creations",
                    ImageUrl = "atelier3.jpg",
                    Location = "Westtown",
                    priceRange = 12000
                },
                new Atelier 
                { 
                    Id = 5,
                    Name = "Chic Styles",
                    ImageUrl = "atelier4.jpg",
                    Location = "Downtown",
                    priceRange = 6000
                },
                new Atelier 
                {   Id = 6,
                    Name = "Vintage Touch",
                    ImageUrl = "atelier7.jpg",
                    Location = "Uptown",
                    priceRange = 8000
                },
                new Atelier 
                { 
                    Id = 7,
                    Name = "Modern Artistry",
                    ImageUrl = "atelier5.jpg",
                    Location = "Downtown",
                    priceRange = 2000
                },
                new Atelier
                {  
                    Id = 8,
                    Name = "Exquisite Design",
                    Location = "East End",
                    ImageUrl = "atelier1.jpg",
                    priceRange = 3000
                },
                new Atelier 
                {  
                    Id = 9,
                    Name = "Timeless Beauty",
                    Location = "West End",
                    ImageUrl = "Atelier (3).jpeg",
                    priceRange = 8000
                },
                new Atelier
                { 
                    Id = 10,
                    Name = "Fashion Forward",
                    Location = "Central Square",
                    ImageUrl = "Atelier (19).jpeg",
                    priceRange = 7000
                },
                 new Atelier
                {
                    Id = 11,
                    Name = "Style Studio",
                    Location = "Central Square",
                    ImageUrl = "Atelier (20).jpeg",
                    priceRange = 1500
                },
                new Atelier
                {
                    Id = 12,
                    Name = "Elegance Edge",
                    Location = "Central Square",
                    ImageUrl = "Atelier (21).jpeg",
                    priceRange = 5500
                },
                new Atelier
                {
                    Id = 13,
                    Name = "Vogue Venue",
                    Location = "Central Square",
                    ImageUrl = "Atelier (22).jpeg",
                    priceRange = 2400
                },
                new Atelier
                {
                    Id = 14,
                    Name = "Chic Charm",
                    Location = "Central Square",
                    ImageUrl = "Atelier (23).jpeg",
                    priceRange = 8200
                },
                new Atelier
                {
                    Id = 15,
                    Name = "Glamour Gate",
                    Location = "Central Square",
                    ImageUrl = "Atelier (24).jpeg",
                    priceRange = 4300
                },
                new Atelier
                {
                    Id = 16,
                    Name = "Runway Room",
                    Location = "Central Square",
                    ImageUrl = "Atelier (25).jpeg",
                    priceRange = 4200
                },
                new Atelier
                {
                    Id = 17,
                    Name = "Trendy Touch",
                    Location = "Central Square",
                    ImageUrl = "Atelier (26).jpeg",
                    priceRange = 3500
                },
                new Atelier
                {
                    Id = 18,
                    Name = "Haute Hub",
                    Location = "Central Square",
                    ImageUrl = "Atelier (27).jpeg",
                    priceRange = 2900
                },
                new Atelier
                {
                    Id = 19,
                    Name = "Modish Moments",
                    Location = "Central Square",
                    ImageUrl = "Atelier (28).jpeg",
                    priceRange = 4400
                },
                new Atelier
                {
                    Id = 20,
                    Name = "Catwalk Corner",
                    Location = "Central Square",
                    ImageUrl = "Atelier (29).jpeg",
                    priceRange = 1100
                }

            );

            modelBuilder.Entity<AtelierImages>().HasData(
                new AtelierImages { Id = 1, AtelierId = 1, ImageUrl = "atelier1.jpg" },
                new AtelierImages { Id = 2, AtelierId = 1, ImageUrl = "atelier2.jpg" },
                new AtelierImages { Id = 3, AtelierId = 1, ImageUrl = "atelier3.jpg" },
                new AtelierImages { Id = 4, AtelierId = 2, ImageUrl = "atelier4.jpg" },
                new AtelierImages { Id = 5, AtelierId = 2, ImageUrl = "atelier5.jpg" },
                new AtelierImages { Id = 6, AtelierId = 2, ImageUrl = "atelier6.jpg" },
                new AtelierImages { Id = 7, AtelierId = 3, ImageUrl = "atelier7.jpg" },
                new AtelierImages { Id = 8, AtelierId = 3, ImageUrl = "Atelier (1).jpeg" },
                new AtelierImages { Id = 9, AtelierId = 3, ImageUrl = "Atelier (2).jpeg" },
                new AtelierImages { Id = 10, AtelierId = 4, ImageUrl = "Atelier (3).jpeg" },
                new AtelierImages { Id = 11, AtelierId = 4, ImageUrl = "atelier1.jpg" },
                new AtelierImages { Id = 12, AtelierId = 4, ImageUrl = "Atelier (20).jpeg" },
                new AtelierImages { Id = 13, AtelierId = 5, ImageUrl = "Atelier (21).jpeg" },
                new AtelierImages { Id = 14, AtelierId = 5, ImageUrl = "Atelier (22).jpeg" },
                new AtelierImages { Id = 15, AtelierId = 5, ImageUrl = "Atelier (23).jpeg" },
                new AtelierImages { Id = 16, AtelierId = 6, ImageUrl = "Atelier (24).jpeg" },
                new AtelierImages { Id = 17, AtelierId = 6, ImageUrl = "Atelier (25).jpeg" },
                new AtelierImages { Id = 18, AtelierId = 6, ImageUrl = "Atelier (26).jpeg" },
                new AtelierImages { Id = 19, AtelierId = 7, ImageUrl = "Atelier (27).jpeg" },
                new AtelierImages { Id = 20, AtelierId = 7, ImageUrl = "Atelier (28).jpeg" },
                new AtelierImages { Id = 21, AtelierId = 7, ImageUrl = "Atelier (29).jpeg" },
                new AtelierImages { Id = 22, AtelierId = 7, ImageUrl = "Atelier (4).jpeg" },
                new AtelierImages { Id = 23, AtelierId = 8, ImageUrl = "Atelier (5).jpeg" },
                new AtelierImages { Id = 24, AtelierId = 8, ImageUrl = "Atelier (6).jpeg" },
                new AtelierImages { Id = 25, AtelierId = 8, ImageUrl = "Atelier (7).jpeg" },
                new AtelierImages { Id = 26, AtelierId = 9, ImageUrl = "Atelier (8).jpeg" },
                new AtelierImages { Id = 27, AtelierId = 9, ImageUrl = "Atelier (9).jpeg" },
                new AtelierImages { Id = 28, AtelierId = 9, ImageUrl = "Atelier (10).jpeg" },
                new AtelierImages { Id = 29, AtelierId = 10, ImageUrl = "Atelier (11).jpeg" },
                new AtelierImages { Id = 30, AtelierId = 10, ImageUrl = "Atelier (12).jpeg" },
                new AtelierImages { Id = 31, AtelierId = 10, ImageUrl = "Atelier (13).jpeg" },
                new AtelierImages { Id = 32, AtelierId = 11, ImageUrl = "Atelier (14).jpeg" },
                new AtelierImages { Id = 33, AtelierId = 11, ImageUrl = "Atelier (15).jpeg" },
                new AtelierImages { Id = 34, AtelierId = 11, ImageUrl = "Atelier (16).jpeg" },
                new AtelierImages { Id = 35, AtelierId = 12, ImageUrl = "Atelier (17).jpeg" },
                new AtelierImages { Id = 36, AtelierId = 12, ImageUrl = "Atelier (18).jpeg" },
                new AtelierImages { Id = 37, AtelierId = 12, ImageUrl = "Atelier (19).jpeg" },
                new AtelierImages { Id = 38, AtelierId = 13, ImageUrl = "Atelier (1).jpeg" },
                new AtelierImages { Id = 39, AtelierId = 13, ImageUrl = "Atelier (5).jpeg" },
                new AtelierImages { Id = 40, AtelierId = 13, ImageUrl = "Atelier (9).jpeg" },
                new AtelierImages { Id = 41, AtelierId = 14, ImageUrl = "Atelier (20).jpeg" },
                new AtelierImages { Id = 42, AtelierId = 14, ImageUrl = "Atelier (15).jpeg" }

            );

            modelBuilder.Entity<Hall>().HasData(
                new Hall { Id = 1, Name = "Grand Hall", Capacity = 500, Location = "Downtown", Price = 10000, ImageUrl="hall1.jpg" },
                new Hall { Id = 2, Name = "Crystal Ballroom", Capacity = 300, Location = "City Center", Price = 7500, ImageUrl = "hall2.jpg" },
                new Hall { Id = 3, Name = "Sunset Venue", Capacity = 200, Location = "Beachside", Price = 6000, ImageUrl = "hall3.jpg" },
                new Hall { Id = 4, Name = "Majestic Hall", Capacity = 400, Location = "Uptown", Price = 9000, ImageUrl = "hall4.jpg" },
                new Hall { Id = 5, Name = "Ocean View", Capacity = 350, Location = "Coastal Road", Price = 8500, ImageUrl = "Hall (5).jpeg" },
                new Hall { Id = 6, Name = "Skyline Pavilion", Capacity = 600, Location = "High Tower", Price = 12000, ImageUrl = "hall1.jpg" },
                new Hall { Id = 7, Name = "Moonlight Hall", Capacity = 250, Location = "Garden District", Price = 7000, ImageUrl = "hall2.jpg" },
                new Hall { Id = 8, Name = "Royal Suite", Capacity = 450, Location = "Palace Street", Price = 11000, ImageUrl = "hall3.jpg" },
                new Hall { Id = 9, Name = "Elite Venue", Capacity = 500, Location = "Central Park", Price = 10500, ImageUrl = "hall4.jpg" },
                new Hall { Id = 10, Name = "Luxury Retreat", Capacity = 700, Location = "Mountain View", Price = 13000, ImageUrl = "hall3.jpg" }
            );

            modelBuilder.Entity<HallImage>().HasData(
                new HallImage { Id = 1, HallId = 1, ImageUrl = "hall1.jpg" },
                new HallImage { Id = 2, HallId = 1, ImageUrl = "hall2.jpg" },
                new HallImage { Id = 3, HallId = 1, ImageUrl = "hall3.jpg" },
                new HallImage { Id = 4, HallId = 2, ImageUrl = "hall4.jpg" },
                new HallImage { Id = 5, HallId = 2, ImageUrl = "Hall (5).jpeg" },
                new HallImage { Id = 6, HallId = 2, ImageUrl = "Hall (6).jpeg" },
                new HallImage { Id = 7, HallId = 3, ImageUrl = "Hall (7).jpeg" },
                new HallImage { Id = 8, HallId = 3, ImageUrl = "Hall (8).jpeg" },
                new HallImage { Id = 9, HallId = 3, ImageUrl = "Hall (9).jpeg" },
                new HallImage { Id = 10, HallId = 4, ImageUrl = "Hall (10).jpeg" },
                new HallImage { Id = 11, HallId = 4, ImageUrl = "Hall (11).jpeg" },
                new HallImage { Id = 12, HallId = 4, ImageUrl = "Hall (12).jpeg" }

            );

            modelBuilder.Entity<MakeUp_Service>().HasData(
                 new MakeUp_Service { Id = 1, Name = "Bridal Makeup", Price = 1500, Description = "Elegant and long-lasting bridal look tailored for your special day.", ImageUrl="makeUp1.jpg" },
                 new MakeUp_Service { Id = 2, Name = "Party Glam", Price = 800, Description = "Bold, vibrant look perfect for parties and night-outs.", ImageUrl = "makeUp2.jpg" },
                 new MakeUp_Service { Id = 3, Name = "Natural Look", Price = 500, Description = "Soft, minimal makeup enhancing your natural beauty.", ImageUrl = "makeUp3.jpg" },
                 new MakeUp_Service { Id = 4, Name = "Evening Elegance", Price = 1000, Description = "Sophisticated makeup style ideal for evening events.", ImageUrl = "makeUp4.jpg" },
                 new MakeUp_Service { Id = 5, Name = "Glamour Shine", Price = 1200, Description = "Shiny, high-glam look with glowing highlights and contouring.", ImageUrl = "makeUp5.jpg" },
                 new MakeUp_Service { Id = 6, Name = "Festival Glam", Price = 700, Description = "Colorful and creative look, perfect for festivals and themed events.", ImageUrl = "makeUp6.jpg" },
                 new MakeUp_Service { Id = 7, Name = "Bridal Glow", Price = 1600, Description = "Radiant bridal makeup focused on glowing skin and soft tones.", ImageUrl = "makeUp7.jpg" },
                 new MakeUp_Service { Id = 8, Name = "Special Occasion", Price = 1300, Description = "Tailored makeup style for birthdays, graduations, and formal events.", ImageUrl = "makeUp8.jpg" },
                 new MakeUp_Service { Id = 9, Name = "Celebrity Look", Price = 2000, Description = "Inspired by red carpet celebrities with dramatic, flawless finish.", ImageUrl = "MakeUp (9).jpeg" },
                 new MakeUp_Service { Id = 10, Name = "Simple Elegance", Price = 600, Description = "Effortless and neat makeup for a clean and graceful appearance.", ImageUrl = "MakeUp (10).jpeg" }
            );

            modelBuilder.Entity<MakeUpImages>().HasData(
                new MakeUpImages { Id = 1, MakeUp_ServiceId = 1, ImageUrl = "makeUp1.jpg" },
                new MakeUpImages { Id = 2, MakeUp_ServiceId = 1, ImageUrl = "makeUp2.jpg" },
                new MakeUpImages { Id = 3, MakeUp_ServiceId = 1, ImageUrl = "makeUp3.jpg" },
                new MakeUpImages { Id = 4, MakeUp_ServiceId = 2, ImageUrl = "makeUp4.jpg" },
                new MakeUpImages { Id = 5, MakeUp_ServiceId = 2, ImageUrl = "makeUp5.jpg" },
                new MakeUpImages { Id = 6, MakeUp_ServiceId = 2, ImageUrl = "makeUp6.jpg" },
                new MakeUpImages { Id = 7, MakeUp_ServiceId = 3, ImageUrl = "makeUp7.jpg" },
                new MakeUpImages { Id = 8, MakeUp_ServiceId = 3, ImageUrl = "makeUp8.jpg" },
                new MakeUpImages { Id = 9, MakeUp_ServiceId = 3, ImageUrl = "MakeUp (1).jpeg" },
                new MakeUpImages { Id = 10, MakeUp_ServiceId = 4, ImageUrl = "MakeUp (2).jpeg" },
                new MakeUpImages { Id = 11, MakeUp_ServiceId = 4, ImageUrl = "MakeUp (3).jpeg" },
                new MakeUpImages { Id = 12, MakeUp_ServiceId = 4, ImageUrl = "MakeUp (4).jpeg" }

            );

            modelBuilder.Entity<Decor>().HasData(
                new Decor { Id = 1, Style = "Classic", Price = 5000, Description = "Timeless elegance with ornate details and rich colors.", ImageUrl = "decor1.jpg" },
                new Decor { Id = 2, Style = "Modern", Price = 7000, Description = "Sleek lines and neutral tones for a chic, modern vibe.", ImageUrl = "decor2.jpg" },
                new Decor { Id = 3, Style = "Rustic", Price = 4500, Description = "Warm and cozy decor with natural wood and earthy tones.", ImageUrl = "decor3.jpg" },
                new Decor { Id = 4, Style = "Vintage", Price = 5500, Description = "Retro charm with antique pieces and soft pastels.", ImageUrl = "decor4.jpg" },
                new Decor { Id = 5, Style = "Industrial", Price = 6000, Description = "Urban-inspired look with metal accents and raw finishes.", ImageUrl = "decor5.jpg" },
                new Decor { Id = 6, Style = "Boho", Price = 4000, Description = "Free-spirited design with bold colors and eclectic elements.", ImageUrl = "decor1.jpg" },
                new Decor { Id = 7, Style = "Minimalist", Price = 6500, Description = "Clean lines, simplicity, and clutter-free design.", ImageUrl = "decor3.jpg" },
                new Decor { Id = 8, Style = "Art Deco", Price = 7000, Description = "Glamorous style with bold geometry and luxurious finishes.", ImageUrl = "decor6.jpg" },
                new Decor { Id = 9, Style = "Glam", Price = 8000, Description = "High-end sparkle with crystal accents and rich fabrics.", ImageUrl = "decor5.jpg" },
                new Decor { Id = 10, Style = "Shabby Chic", Price = 4500, Description = "Soft, feminine style with distressed furniture and florals.", ImageUrl = "decor2.jpg" }
            );

            modelBuilder.Entity<DecoreImage>().HasData(
                new DecoreImage { Id = 1, DecorId = 1, ImageUrl = "decor1.jpg" },
                new DecoreImage { Id = 2, DecorId = 1, ImageUrl = "decor2.jpg" },
                new DecoreImage { Id = 3, DecorId = 1, ImageUrl = "decor3.jpg" },
                new DecoreImage { Id = 4, DecorId = 2, ImageUrl = "decor4.jpg" },
                new DecoreImage { Id = 5, DecorId = 2, ImageUrl = "decor5.jpg" },
                new DecoreImage { Id = 6, DecorId = 2, ImageUrl = "decor6.jpg" },
                new DecoreImage { Id = 7, DecorId = 3, ImageUrl = "decor2.jpg" },
                new DecoreImage { Id = 8, DecorId = 3, ImageUrl = "decor3.jpg" },
                new DecoreImage { Id = 9, DecorId = 3, ImageUrl = "decor4.jpg" },
                new DecoreImage { Id = 10, DecorId = 4, ImageUrl = "decor1.jpg" },
                new DecoreImage { Id = 11, DecorId = 4, ImageUrl = "decor2.jpg" },
                new DecoreImage { Id = 12, DecorId = 4, ImageUrl = "decor5.jpg" },
                new DecoreImage { Id = 13, DecorId = 5, ImageUrl = "decor2.jpg" },
                new DecoreImage { Id = 14, DecorId = 5, ImageUrl = "decor3.jpg" },
                new DecoreImage { Id = 15, DecorId = 5, ImageUrl = "decor4.jpg" }

                );

            modelBuilder.Entity<Session>().HasData(
                new Session { Id = 1, Name = "Photography Session", Location = "Studio A", Type = "Photography", Duration = 2, Price = 1000, Description = "Professional photo session for any occasion.", ImageUrl = "session1.jpg" },
                new Session { Id = 2, Name = "Cinematic Videography", Location = "Outdoor Locations", Type = "Videography", Duration = 3, Price = 1500, Description = "Capture every moment with cinematic quality.", ImageUrl = "session2.jpg" },
                new Session { Id = 3, Name = "Engagement Shoot", Location = "Romantic Spots", Type = "Engagement Shoot", Duration = 4, Price = 2000, Description = "Celebrate your engagement with a memorable shoot.", ImageUrl = "session3.jpg" },
                new Session { Id = 4, Name = "Pre-Wedding Shoot", Location = "Garden Venue", Type = "Pre-Wedding Shoot", Duration = 5, Price = 2500, Description = "Romantic photo session before your big day.", ImageUrl = "session4.jpg" },
                new Session { Id = 5, Name = "Wedding Photography", Location = "Wedding Venue", Type = "Wedding Photography", Duration = 6, Price = 4000, Description = "Full-day photography service for weddings.", ImageUrl = "session5.jpg" },
                new Session { Id = 6, Name = "Couple's Love Shoot", Location = "Scenic Outdoor Locations", Type = "Couple Shoot", Duration = 2, Price = 1200, Description = "Capture the love and connection between you two.", ImageUrl = "session6.jpg" },
                new Session { Id = 7, Name = "Bridal Portrait Session", Location = "Studio", Type = "Bridal Portraits", Duration = 3, Price = 1800, Description = "Elegant portraits for the bride in her gown.", ImageUrl = "session7.jpg" },
                new Session { Id = 8, Name = "High Fashion Shoot", Location = "Fashion Studio", Type = "Fashion Photography", Duration = 4, Price = 2200, Description = "High-end fashion shoot for models or brands.", ImageUrl = "session8.jpg" },
                new Session { Id = 9, Name = "Event Photography & Videography", Location = "Event Venue", Type = "Event Coverage", Duration = 5, Price = 3000, Description = "Photography and videography coverage for events.", ImageUrl = "session9.jpg" },
                new Session { Id = 10, Name = "Family Photography", Location = "Home or Outdoor", Type = "Family Shoot", Duration = 3, Price = 1400, Description = "Heartwarming family photography session.", ImageUrl = "session3.jpg" }
            );

            modelBuilder.Entity<SessionImages>().HasData(
                new SessionImages { Id = 1, SessionId = 1, ImageUrl = "session1.jpg" },
                new SessionImages { Id = 2, SessionId = 1, ImageUrl = "session2.jpg" },
                new SessionImages { Id = 3, SessionId = 1, ImageUrl = "session3.jpg" },
                new SessionImages { Id = 4, SessionId = 2, ImageUrl = "session4.jpg" },
                new SessionImages { Id = 5, SessionId = 2, ImageUrl = "session5.jpg" },
                new SessionImages { Id = 6, SessionId = 2, ImageUrl = "session6.jpg" },
                new SessionImages { Id = 7, SessionId = 3, ImageUrl = "session7.jpg" },
                new SessionImages { Id = 8, SessionId = 3, ImageUrl = "session8.jpg" },
                new SessionImages { Id = 9, SessionId = 3, ImageUrl = "session9.jpg" },
                new SessionImages { Id = 10, SessionId = 4, ImageUrl = "session1.jpg" },
                new SessionImages { Id = 11, SessionId = 4, ImageUrl = "session8.jpg" },
                new SessionImages { Id = 12, SessionId = 4, ImageUrl = "session4.jpg" },
                new SessionImages { Id = 13, SessionId = 5, ImageUrl = "session2.jpg" },
                new SessionImages { Id = 14, SessionId = 5, ImageUrl = "session7.jpg" },
                new SessionImages { Id = 15, SessionId = 5, ImageUrl = "session5.jpg" }

            );

        }
    }
}
