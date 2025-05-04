using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ateliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    priceRange = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ateliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MakeUpServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ServiceType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtelierImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtelierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtelierImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtelierImages_Ateliers_AtelierId",
                        column: x => x.AtelierId,
                        principalTable: "Ateliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DecoreImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecoreImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DecoreImage_Decors_DecorId",
                        column: x => x.DecorId,
                        principalTable: "Decors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HallImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HallId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HallImages_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MakeUpImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakeUp_ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MakeUpImages_MakeUpServices_MakeUp_ServiceId",
                        column: x => x.MakeUp_ServiceId,
                        principalTable: "MakeUpServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hall_Id = table.Column<int>(type: "int", nullable: true),
                    Session_Id = table.Column<int>(type: "int", nullable: true),
                    Atelier_Id = table.Column<int>(type: "int", nullable: true),
                    MakeupId = table.Column<int>(type: "int", nullable: true),
                    Decor_Id = table.Column<int>(type: "int", nullable: true),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Ateliers_Atelier_Id",
                        column: x => x.Atelier_Id,
                        principalTable: "Ateliers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Decors_Decor_Id",
                        column: x => x.Decor_Id,
                        principalTable: "Decors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Halls_Hall_Id",
                        column: x => x.Hall_Id,
                        principalTable: "Halls",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_MakeUpServices_MakeupId",
                        column: x => x.MakeupId,
                        principalTable: "MakeUpServices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Sessions_Session_Id",
                        column: x => x.Session_Id,
                        principalTable: "Sessions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SessionImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionImages_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09970960-568f-421a-855d-9c2e22205af2", 0, "b65df7bb-22a7-458d-a45c-1b3e9b1839d6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJjlvyUgIDaLHTZqCpMD4gHnkv9e887fOkJiDjF2xGoJwtY5efw4JiNI6SRUpKbmyQ==", "0123456789", true, "8a1ac1fa-3358-4d40-b9e7-a890c9aac316", false, "admin@example.com" },
                    { "8aa98e10-33a4-412a-8cd4-edb609f077d5", 0, "0a03c815-7c19-4e35-9da9-b5b3eb47c04a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIP/W0E/SkD5mRD9O4dSxOz6kjNG8YMgiCr7zdTs/ZGegstn0eDd/puIbkqQNC6+bg==", "9876543210", true, "fe9b6409-a3f8-4a53-ae69-0f77d155b1d1", false, "user@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Ateliers",
                columns: new[] { "Id", "ImageUrl", "Location", "Name", "priceRange" },
                values: new object[,]
                {
                    { 1, "atelier2.jpg", "Uptown", "Elite Atelier", 9000.0 },
                    { 2, "atelier1.jpg", "Downtown", "Royal Designs", 5000.0 },
                    { 3, "atelier5.jpg", "Easttown", "Glamorous Styles", 4000.0 },
                    { 4, "atelier3.jpg", "Westtown", "Elegant Creations", 12000.0 },
                    { 5, "atelier4.jpg", "Downtown", "Chic Styles", 6000.0 },
                    { 6, "atelier7.jpg", "Uptown", "Vintage Touch", 8000.0 },
                    { 7, "atelier5.jpg", "Downtown", "Modern Artistry", 2000.0 },
                    { 8, "atelier1.jpg", "East End", "Exquisite Design", 3000.0 },
                    { 9, "Atelier (3).jpeg", "West End", "Timeless Beauty", 8000.0 },
                    { 10, "Atelier (19).jpeg", "Central Square", "Fashion Forward", 7000.0 },
                    { 11, "Atelier (20).jpeg", "Central Square", "Style Studio", 1500.0 },
                    { 12, "Atelier (21).jpeg", "Central Square", "Elegance Edge", 5500.0 },
                    { 13, "Atelier (22).jpeg", "Central Square", "Vogue Venue", 2400.0 },
                    { 14, "Atelier (23).jpeg", "Central Square", "Chic Charm", 8200.0 },
                    { 15, "Atelier (24).jpeg", "Central Square", "Glamour Gate", 4300.0 },
                    { 16, "Atelier (25).jpeg", "Central Square", "Runway Room", 4200.0 },
                    { 17, "Atelier (26).jpeg", "Central Square", "Trendy Touch", 3500.0 },
                    { 18, "Atelier (27).jpeg", "Central Square", "Haute Hub", 2900.0 },
                    { 19, "Atelier (28).jpeg", "Central Square", "Modish Moments", 4400.0 },
                    { 20, "Atelier (29).jpeg", "Central Square", "Catwalk Corner", 1100.0 }
                });

            migrationBuilder.InsertData(
                table: "Decors",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Style" },
                values: new object[,]
                {
                    { 1, "Timeless elegance with ornate details and rich colors.", "decor1.jpg", 5000, "Classic" },
                    { 2, "Sleek lines and neutral tones for a chic, modern vibe.", "decor2.jpg", 7000, "Modern" },
                    { 3, "Warm and cozy decor with natural wood and earthy tones.", "decor3.jpg", 4500, "Rustic" },
                    { 4, "Retro charm with antique pieces and soft pastels.", "decor4.jpg", 5500, "Vintage" },
                    { 5, "Urban-inspired look with metal accents and raw finishes.", "decor5.jpg", 6000, "Industrial" },
                    { 6, "Free-spirited design with bold colors and eclectic elements.", "decor1.jpg", 4000, "Boho" },
                    { 7, "Clean lines, simplicity, and clutter-free design.", "decor3.jpg", 6500, "Minimalist" },
                    { 8, "Glamorous style with bold geometry and luxurious finishes.", "decor6.jpg", 7000, "Art Deco" },
                    { 9, "High-end sparkle with crystal accents and rich fabrics.", "decor5.jpg", 8000, "Glam" },
                    { 10, "Soft, feminine style with distressed furniture and florals.", "decor2.jpg", 4500, "Shabby Chic" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "ImageUrl", "Location", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 500, "hall1.jpg", "Downtown", "Grand Hall", 10000.0 },
                    { 2, 300, "hall2.jpg", "City Center", "Crystal Ballroom", 7500.0 },
                    { 3, 200, "hall3.jpg", "Beachside", "Sunset Venue", 6000.0 },
                    { 4, 400, "hall4.jpg", "Uptown", "Majestic Hall", 9000.0 },
                    { 5, 350, "Hall (5).jpeg", "Coastal Road", "Ocean View", 8500.0 },
                    { 6, 600, "hall1.jpg", "High Tower", "Skyline Pavilion", 12000.0 },
                    { 7, 250, "hall2.jpg", "Garden District", "Moonlight Hall", 7000.0 },
                    { 8, 450, "hall3.jpg", "Palace Street", "Royal Suite", 11000.0 },
                    { 9, 500, "hall4.jpg", "Central Park", "Elite Venue", 10500.0 },
                    { 10, 700, "hall3.jpg", "Mountain View", "Luxury Retreat", 13000.0 }
                });

            migrationBuilder.InsertData(
                table: "MakeUpServices",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Elegant and long-lasting bridal look tailored for your special day.", "makeUp1.jpg", "Bridal Makeup", 1500 },
                    { 2, "Bold, vibrant look perfect for parties and night-outs.", "makeUp2.jpg", "Party Glam", 800 },
                    { 3, "Soft, minimal makeup enhancing your natural beauty.", "makeUp3.jpg", "Natural Look", 500 },
                    { 4, "Sophisticated makeup style ideal for evening events.", "makeUp4.jpg", "Evening Elegance", 1000 },
                    { 5, "Shiny, high-glam look with glowing highlights and contouring.", "makeUp5.jpg", "Glamour Shine", 1200 },
                    { 6, "Colorful and creative look, perfect for festivals and themed events.", "makeUp6.jpg", "Festival Glam", 700 },
                    { 7, "Radiant bridal makeup focused on glowing skin and soft tones.", "makeUp7.jpg", "Bridal Glow", 1600 },
                    { 8, "Tailored makeup style for birthdays, graduations, and formal events.", "makeUp8.jpg", "Special Occasion", 1300 },
                    { 9, "Inspired by red carpet celebrities with dramatic, flawless finish.", "MakeUp (9).jpeg", "Celebrity Look", 2000 },
                    { 10, "Effortless and neat makeup for a clean and graceful appearance.", "MakeUp (10).jpeg", "Simple Elegance", 600 }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Location", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "Professional photo session for any occasion.", 2, "session1.jpg", "Studio A", "Photography Session", 1000.0, "Photography" },
                    { 2, "Capture every moment with cinematic quality.", 3, "session2.jpg", "Outdoor Locations", "Cinematic Videography", 1500.0, "Videography" },
                    { 3, "Celebrate your engagement with a memorable shoot.", 4, "session3.jpg", "Romantic Spots", "Engagement Shoot", 2000.0, "Engagement Shoot" },
                    { 4, "Romantic photo session before your big day.", 5, "session4.jpg", "Garden Venue", "Pre-Wedding Shoot", 2500.0, "Pre-Wedding Shoot" },
                    { 5, "Full-day photography service for weddings.", 6, "session5.jpg", "Wedding Venue", "Wedding Photography", 4000.0, "Wedding Photography" },
                    { 6, "Capture the love and connection between you two.", 2, "session6.jpg", "Scenic Outdoor Locations", "Couple's Love Shoot", 1200.0, "Couple Shoot" },
                    { 7, "Elegant portraits for the bride in her gown.", 3, "session7.jpg", "Studio", "Bridal Portrait Session", 1800.0, "Bridal Portraits" },
                    { 8, "High-end fashion shoot for models or brands.", 4, "session8.jpg", "Fashion Studio", "High Fashion Shoot", 2200.0, "Fashion Photography" },
                    { 9, "Photography and videography coverage for events.", 5, "session9.jpg", "Event Venue", "Event Photography & Videography", 3000.0, "Event Coverage" },
                    { 10, "Heartwarming family photography session.", 3, "session3.jpg", "Home or Outdoor", "Family Photography", 1400.0, "Family Shoot" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "09970960-568f-421a-855d-9c2e22205af2" },
                    { "2", "8aa98e10-33a4-412a-8cd4-edb609f077d5" }
                });

            migrationBuilder.InsertData(
                table: "AtelierImages",
                columns: new[] { "Id", "AtelierId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "atelier1.jpg" },
                    { 2, 1, "atelier2.jpg" },
                    { 3, 1, "atelier3.jpg" },
                    { 4, 2, "atelier4.jpg" },
                    { 5, 2, "atelier5.jpg" },
                    { 6, 2, "atelier6.jpg" },
                    { 7, 3, "atelier7.jpg" },
                    { 8, 3, "Atelier (1).jpeg" },
                    { 9, 3, "Atelier (2).jpeg" },
                    { 10, 4, "Atelier (3).jpeg" },
                    { 11, 4, "atelier1.jpg" },
                    { 12, 4, "Atelier (20).jpeg" },
                    { 13, 5, "Atelier (21).jpeg" },
                    { 14, 5, "Atelier (22).jpeg" },
                    { 15, 5, "Atelier (23).jpeg" },
                    { 16, 6, "Atelier (24).jpeg" },
                    { 17, 6, "Atelier (25).jpeg" },
                    { 18, 6, "Atelier (26).jpeg" },
                    { 19, 7, "Atelier (27).jpeg" },
                    { 20, 7, "Atelier (28).jpeg" },
                    { 21, 7, "Atelier (29).jpeg" },
                    { 22, 7, "Atelier (4).jpeg" },
                    { 23, 8, "Atelier (5).jpeg" },
                    { 24, 8, "Atelier (6).jpeg" },
                    { 25, 8, "Atelier (7).jpeg" },
                    { 26, 9, "Atelier (8).jpeg" },
                    { 27, 9, "Atelier (9).jpeg" },
                    { 28, 9, "Atelier (10).jpeg" },
                    { 29, 10, "Atelier (11).jpeg" },
                    { 30, 10, "Atelier (12).jpeg" },
                    { 31, 10, "Atelier (13).jpeg" },
                    { 32, 11, "Atelier (14).jpeg" },
                    { 33, 11, "Atelier (15).jpeg" },
                    { 34, 11, "Atelier (16).jpeg" },
                    { 35, 12, "Atelier (17).jpeg" },
                    { 36, 12, "Atelier (18).jpeg" },
                    { 37, 12, "Atelier (19).jpeg" },
                    { 38, 13, "Atelier (1).jpeg" },
                    { 39, 13, "Atelier (5).jpeg" },
                    { 40, 13, "Atelier (9).jpeg" },
                    { 41, 14, "Atelier (20).jpeg" },
                    { 42, 14, "Atelier (15).jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Atelier_Id", "Created_at", "Decor_Id", "Hall_Id", "MakeupId", "Session_Id", "Status", "user_id" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2025, 4, 13, 12, 8, 19, 558, DateTimeKind.Local).AddTicks(8980), 1, 2, 1, 2, "Confirmed", "09970960-568f-421a-855d-9c2e22205af2" },
                    { 2, 1, new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, 4, 1, "Pending", "09970960-568f-421a-855d-9c2e22205af2" },
                    { 3, 3, new DateTime(2025, 4, 13, 12, 8, 19, 558, DateTimeKind.Local).AddTicks(9117), 1, 2, 1, 2, "Confirmed", "09970960-568f-421a-855d-9c2e22205af2" },
                    { 4, 1, new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, 4, 1, "Pending", "09970960-568f-421a-855d-9c2e22205af2" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ServiceId", "ServiceType", "UserId" },
                values: new object[] { 1, "Excellent service!", new DateTime(2025, 4, 13, 12, 8, 19, 558, DateTimeKind.Local).AddTicks(9188), 0, 0, "09970960-568f-421a-855d-9c2e22205af2" });

            migrationBuilder.InsertData(
                table: "DecoreImage",
                columns: new[] { "Id", "DecorId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "decor1.jpg" },
                    { 2, 1, "decor2.jpg" },
                    { 3, 1, "decor3.jpg" },
                    { 4, 2, "decor4.jpg" },
                    { 5, 2, "decor5.jpg" },
                    { 6, 2, "decor6.jpg" },
                    { 7, 3, "decor2.jpg" },
                    { 8, 3, "decor3.jpg" },
                    { 9, 3, "decor4.jpg" },
                    { 10, 4, "decor1.jpg" },
                    { 11, 4, "decor2.jpg" },
                    { 12, 4, "decor5.jpg" },
                    { 13, 5, "decor2.jpg" },
                    { 14, 5, "decor3.jpg" },
                    { 15, 5, "decor4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "HallImages",
                columns: new[] { "Id", "HallId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "hall1.jpg" },
                    { 2, 1, "hall2.jpg" },
                    { 3, 1, "hall3.jpg" },
                    { 4, 2, "hall4.jpg" },
                    { 5, 2, "Hall (5).jpeg" },
                    { 6, 2, "Hall (6).jpeg" },
                    { 7, 3, "Hall (7).jpeg" },
                    { 8, 3, "Hall (8).jpeg" },
                    { 9, 3, "Hall (9).jpeg" },
                    { 10, 4, "Hall (10).jpeg" },
                    { 11, 4, "Hall (11).jpeg" },
                    { 12, 4, "Hall (12).jpeg" }
                });

            migrationBuilder.InsertData(
                table: "MakeUpImages",
                columns: new[] { "Id", "ImageUrl", "MakeUp_ServiceId" },
                values: new object[,]
                {
                    { 1, "makeUp1.jpg", 1 },
                    { 2, "makeUp2.jpg", 1 },
                    { 3, "makeUp3.jpg", 1 },
                    { 4, "makeUp4.jpg", 2 },
                    { 5, "makeUp5.jpg", 2 },
                    { 6, "makeUp6.jpg", 2 },
                    { 7, "makeUp7.jpg", 3 },
                    { 8, "makeUp8.jpg", 3 },
                    { 9, "MakeUp (1).jpeg", 3 },
                    { 10, "MakeUp (2).jpeg", 4 },
                    { 11, "MakeUp (3).jpeg", 4 },
                    { 12, "MakeUp (4).jpeg", 4 }
                });

            migrationBuilder.InsertData(
                table: "SessionImages",
                columns: new[] { "Id", "ImageUrl", "SessionId" },
                values: new object[,]
                {
                    { 1, "session1.jpg", 1 },
                    { 2, "session2.jpg", 1 },
                    { 3, "session3.jpg", 1 },
                    { 4, "session4.jpg", 2 },
                    { 5, "session5.jpg", 2 },
                    { 6, "session6.jpg", 2 },
                    { 7, "session7.jpg", 3 },
                    { 8, "session8.jpg", 3 },
                    { 9, "session9.jpg", 3 },
                    { 10, "session1.jpg", 4 },
                    { 11, "session8.jpg", 4 },
                    { 12, "session4.jpg", 4 },
                    { 13, "session2.jpg", 5 },
                    { 14, "session7.jpg", 5 },
                    { 15, "session5.jpg", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AtelierImages_AtelierId",
                table: "AtelierImages",
                column: "AtelierId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Atelier_Id",
                table: "Bookings",
                column: "Atelier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Decor_Id",
                table: "Bookings",
                column: "Decor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Hall_Id",
                table: "Bookings",
                column: "Hall_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_MakeupId",
                table: "Bookings",
                column: "MakeupId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Session_Id",
                table: "Bookings",
                column: "Session_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_user_id",
                table: "Bookings",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DecoreImage_DecorId",
                table: "DecoreImage",
                column: "DecorId");

            migrationBuilder.CreateIndex(
                name: "IX_HallImages_HallId",
                table: "HallImages",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUpImages_MakeUp_ServiceId",
                table: "MakeUpImages",
                column: "MakeUp_ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionImages_SessionId",
                table: "SessionImages",
                column: "SessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AtelierImages");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DecoreImage");

            migrationBuilder.DropTable(
                name: "HallImages");

            migrationBuilder.DropTable(
                name: "MakeUpImages");

            migrationBuilder.DropTable(
                name: "SessionImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ateliers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Decors");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "MakeUpServices");

            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
