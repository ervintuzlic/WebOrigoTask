using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOrigoTask.Data.Migrations
{
    public partial class DBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tablets",
                columns: table => new
                {
                    deviceId = table.Column<string>(type: "TEXT", nullable: false),
                    deviceType = table.Column<string>(type: "TEXT", nullable: false),
                    activationCode = table.Column<string>(type: "TEXT", maxLength: 16, nullable: false),
                    accept = table.Column<string>(type: "TEXT", nullable: false),
                    appVersion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablets", x => x.deviceId);
                });

            migrationBuilder.InsertData(
                table: "Tablets",
                columns: new[] { "deviceId", "accept", "activationCode", "appVersion", "deviceType" },
                values: new object[] { "NW-H-20-0017", "", "XJ235IAH245D2O", "", "unset" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tablets");
        }
    }
}
