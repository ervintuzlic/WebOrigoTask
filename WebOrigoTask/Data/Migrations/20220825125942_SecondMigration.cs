using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOrigoTask.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "accept",
                table: "Tablets",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "appversion",
                table: "Tablets",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Tablets",
                keyColumn: "device_id",
                keyValue: 1,
                columns: new[] { "accept", "appversion" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tablets",
                keyColumn: "device_id",
                keyValue: 2,
                columns: new[] { "accept", "appversion" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tablets",
                keyColumn: "device_id",
                keyValue: 3,
                columns: new[] { "accept", "appversion" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tablets",
                keyColumn: "device_id",
                keyValue: 4,
                columns: new[] { "accept", "appversion" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tablets",
                keyColumn: "device_id",
                keyValue: 5,
                columns: new[] { "accept", "appversion" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tablets",
                keyColumn: "device_id",
                keyValue: 6,
                columns: new[] { "accept", "appversion" },
                values: new object[] { "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accept",
                table: "Tablets");

            migrationBuilder.DropColumn(
                name: "appversion",
                table: "Tablets");
        }
    }
}
