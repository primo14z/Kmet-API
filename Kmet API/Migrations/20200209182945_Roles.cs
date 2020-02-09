using Microsoft.EntityFrameworkCore.Migrations;

namespace Kmet_API.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee9ee827-c5a8-4c36-9e6f-d6bf4a823a10", "269535a1-dac5-40b4-9b69-c8b1aacecb27", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8bf5302-d185-4658-9269-88441bee79cb", "6b01dd2b-5a78-4f23-9770-154e87809936", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6a0dd23-ab51-45c9-b02e-c4fe417b5a4f", "2a8c3416-890d-4aa7-9faf-48304854b681", "Seller", "SELLER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee9ee827-c5a8-4c36-9e6f-d6bf4a823a10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6a0dd23-ab51-45c9-b02e-c4fe417b5a4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8bf5302-d185-4658-9269-88441bee79cb");
        }
    }
}
