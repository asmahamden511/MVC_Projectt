using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "4b686451-182a-4c02-af05-f93cb15bb738" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "51a3f218-4855-4c7a-a775-59474274c3b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ed6d0ad-c304-4424-8ef8-1c2144ec346a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f06f11e-d387-4d4b-8d50-6f72589484ec");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f7ddbc4-30f9-4b10-aa32-0d34cba88771", 0, "cec9ac30-1feb-44cd-ad72-feb2204448eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKQMPrx3tHktPnrZwZ60wbAYvCJYHEj/2wbPnkFJekMR020XC9/wSyGTAT6kbPWf5w==", "9876543210", true, "264fd20d-0ab5-474a-a785-9ee5eb85c6ce", false, "user@example.com" },
                    { "4d671fd5-cc3a-4b31-a34b-6948c1a1bbd3", 0, "a0cdeea0-3c14-4546-8e54-fd42fb12f353", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEETNV1tyjFzNJ1rPIeOo36aHAiZekyWzJbHUo1u6GJkf2Fud+vVL7IV0x8zBVT/05A==", "0123456789", true, "1214be8f-a4f8-4fd6-aa18-ab2090cead25", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 34, 38, 969, DateTimeKind.Local).AddTicks(2188), "4d671fd5-cc3a-4b31-a34b-6948c1a1bbd3" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "4d671fd5-cc3a-4b31-a34b-6948c1a1bbd3");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 34, 38, 969, DateTimeKind.Local).AddTicks(2424), "4d671fd5-cc3a-4b31-a34b-6948c1a1bbd3" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Status", "user_id" },
                values: new object[] { "Pending", "4d671fd5-cc3a-4b31-a34b-6948c1a1bbd3" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 34, 38, 969, DateTimeKind.Local).AddTicks(2558), "4d671fd5-cc3a-4b31-a34b-6948c1a1bbd3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "3f7ddbc4-30f9-4b10-aa32-0d34cba88771" },
                    { "1", "4d671fd5-cc3a-4b31-a34b-6948c1a1bbd3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3f7ddbc4-30f9-4b10-aa32-0d34cba88771" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "4d671fd5-cc3a-4b31-a34b-6948c1a1bbd3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f7ddbc4-30f9-4b10-aa32-0d34cba88771");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d671fd5-cc3a-4b31-a34b-6948c1a1bbd3");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "4b686451-182a-4c02-af05-f93cb15bb738" },
                    { "2", "51a3f218-4855-4c7a-a775-59474274c3b1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ed6d0ad-c304-4424-8ef8-1c2144ec346a", 0, "cbe91c93-b71c-4107-b245-5c32f6b2465c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKhR2VgP+D5SWyM2pP1/pDfOsVLVfalbAj7iKUs7ZLZTVAtDe+iEnpzUQqHD618ReA==", "0123456789", true, "99f7640b-1a50-4fb1-85f9-82d01d29924b", false, "admin@example.com" },
                    { "4f06f11e-d387-4d4b-8d50-6f72589484ec", 0, "d6b268ec-03ee-43cf-a09c-069fb922de4e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMl/Ed0zh2tnqXbkzT0l+q+f7gcRwSPZM3VSRVSEpYvFwRponAWglfQDry0d7O8Gyw==", "9876543210", true, "1600f1b0-f2e8-4270-a3a6-9c40323f00bf", false, "user@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 7, 43, 7, 528, DateTimeKind.Local).AddTicks(6217), "0ed6d0ad-c304-4424-8ef8-1c2144ec346a" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "4b686451-182a-4c02-af05-f93cb15bb738");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 21, 30, 55, 150, DateTimeKind.Local).AddTicks(8741), "0ed6d0ad-c304-4424-8ef8-1c2144ec346a" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Status", "user_id" },
                values: new object[] { null, "0ed6d0ad-c304-4424-8ef8-1c2144ec346a" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 12, 21, 30, 55, 150, DateTimeKind.Local).AddTicks(8799), "0ed6d0ad-c304-4424-8ef8-1c2144ec346a" });
        }
    }
}
