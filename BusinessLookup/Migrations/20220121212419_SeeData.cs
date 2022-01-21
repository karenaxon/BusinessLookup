using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookup.Migrations
{
    public partial class SeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "City", "Name", "State", "StreetAddress", "Type", "ZipCode" },
                values: new object[] { 1, "Bothell", "Julio's", "WA", "123 Street", "Restaurant", "98021" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "City", "Name", "State", "StreetAddress", "Type", "ZipCode" },
                values: new object[] { 2, "Bellevue", "Best Flowers", "WA", "Wonderful Street", "Florist", "98023" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "City", "Name", "State", "StreetAddress", "Type", "ZipCode" },
                values: new object[] { 3, "Renton", "Shinny Clean", "WA", "Main Street", "Dry Cleaner", "98025" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);
        }
    }
}
