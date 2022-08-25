using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOrigoTask.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tablets",
                table: "Tablets");

            migrationBuilder.RenameTable(
                name: "Tablets",
                newName: "Devices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Devices",
                table: "Devices",
                column: "deviceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Devices",
                table: "Devices");

            migrationBuilder.RenameTable(
                name: "Devices",
                newName: "Tablets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tablets",
                table: "Tablets",
                column: "deviceId");
        }
    }
}
