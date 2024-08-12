using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Wissto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("e6a7481f-00e8-495d-8c1a-4e9b13399d4e"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("2188b73c-33ae-459f-98ff-bf65fe58ffdc"), null, "avatar.jpg", "Wissem Hmidi", "Software Developer in C#" });

            migrationBuilder.InsertData(
                table: "PortfolioItems",
                columns: new[] { "Id", "Description", "ImageUrl", "ProjectName" },
                values: new object[,]
                {
                    { new Guid("34b34fbf-4e4e-42b1-ab71-f4915e2ebe84"), "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.", "safe.png", "Project Gamma" },
                    { new Guid("38c8d58e-fc07-449b-9298-5bd4ded8bc60"), "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", "circus.png", "Project Beta" },
                    { new Guid("620fffd2-3b41-4769-ac38-eaf339435438"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Interdum magnis justo primis ligula facilisi non torquent pulvinar. Tellus tortor morbi ullamcorper sagittis proin quam. Parturient Lacinia blandit rutrum; turpis elit taciti dignissim suspendisse. Quis gravida curae, tellus vulputate urna venenatis. Nisl viverra curabitur a pretium suscipit.", "cake.png", "Project Alpha" },
                    { new Guid("f876025d-db45-40f5-bf1b-66cc63b46334"), "Curabitur gravida arcu ac tortor dignissim convallis. Aenean et tortor at risus viverra adipiscing at in tellus.", "submarine.png", "Project Delta" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("2188b73c-33ae-459f-98ff-bf65fe58ffdc"));

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: new Guid("34b34fbf-4e4e-42b1-ab71-f4915e2ebe84"));

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: new Guid("38c8d58e-fc07-449b-9298-5bd4ded8bc60"));

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: new Guid("620fffd2-3b41-4769-ac38-eaf339435438"));

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: new Guid("f876025d-db45-40f5-bf1b-66cc63b46334"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("e6a7481f-00e8-495d-8c1a-4e9b13399d4e"), null, "avatar.jpg", "Wissem Hmidi", "Software Developer in C#" });
        }
    }
}
