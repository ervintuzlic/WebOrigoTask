using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOrigoTask.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tablets",
                columns: table => new
                {
                    device_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    device_type = table.Column<string>(type: "TEXT", nullable: false),
                    activation_code = table.Column<string>(type: "TEXT", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablets", x => x.device_id);
                });

            migrationBuilder.InsertData(
                table: "Tablets",
                columns: new[] { "device_id", "activation_code", "device_type" },
                values: new object[] { 1, "XJ235IAH245D2O", "unset" });

            migrationBuilder.InsertData(
                table: "Tablets",
                columns: new[] { "device_id", "activation_code", "device_type" },
                values: new object[] { 2, "XJ235IAH245D2O", "unset" });

            migrationBuilder.InsertData(
                table: "Tablets",
                columns: new[] { "device_id", "activation_code", "device_type" },
                values: new object[] { 3, "XJ235IAH245D2O", "unset" });

            migrationBuilder.InsertData(
                table: "Tablets",
                columns: new[] { "device_id", "activation_code", "device_type" },
                values: new object[] { 4, "XJ235IAH245D2O", "unset" });

            migrationBuilder.InsertData(
                table: "Tablets",
                columns: new[] { "device_id", "activation_code", "device_type" },
                values: new object[] { 5, "XJ235IAH245D2O", "unset" });

            migrationBuilder.InsertData(
                table: "Tablets",
                columns: new[] { "device_id", "activation_code", "device_type" },
                values: new object[] { 6, "XJ235IAH245D2O", "unset" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tablets");
        }
    }
}
