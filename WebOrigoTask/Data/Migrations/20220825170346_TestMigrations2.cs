using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOrigoTask.Data.Migrations
{
    public partial class TestMigrations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "errorResponses",
                columns: table => new
                {
                    title = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_errorResponses", x => x.title);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "errorResponses");
        }
    }
}
