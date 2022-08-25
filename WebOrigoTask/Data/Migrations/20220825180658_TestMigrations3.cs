using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOrigoTask.Data.Migrations
{
    public partial class TestMigrations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_deviceInfoResponses_deviceInfoResponses_deviceOwnerDetailsdeviceId",
                table: "deviceInfoResponses");

            migrationBuilder.DropIndex(
                name: "IX_deviceInfoResponses_deviceOwnerDetailsdeviceId",
                table: "deviceInfoResponses");

            migrationBuilder.DropColumn(
                name: "deviceOwnerDetailsdeviceId",
                table: "deviceInfoResponses");

            migrationBuilder.AddColumn<string>(
                name: "deviceOwnerDetailsbilling_name",
                table: "deviceInfoResponses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "leasingUpdateRequests",
                columns: table => new
                {
                    deviceId = table.Column<string>(type: "TEXT", nullable: false),
                    deviceTrainings = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leasingUpdateRequests", x => x.deviceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_deviceInfoResponses_deviceOwnerDetailsbilling_name",
                table: "deviceInfoResponses",
                column: "deviceOwnerDetailsbilling_name");

            migrationBuilder.AddForeignKey(
                name: "FK_deviceInfoResponses_DeviceOwnerDetails_deviceOwnerDetailsbilling_name",
                table: "deviceInfoResponses",
                column: "deviceOwnerDetailsbilling_name",
                principalTable: "DeviceOwnerDetails",
                principalColumn: "billing_name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_deviceInfoResponses_DeviceOwnerDetails_deviceOwnerDetailsbilling_name",
                table: "deviceInfoResponses");

            migrationBuilder.DropTable(
                name: "leasingUpdateRequests");

            migrationBuilder.DropIndex(
                name: "IX_deviceInfoResponses_deviceOwnerDetailsbilling_name",
                table: "deviceInfoResponses");

            migrationBuilder.DropColumn(
                name: "deviceOwnerDetailsbilling_name",
                table: "deviceInfoResponses");

            migrationBuilder.AddColumn<string>(
                name: "deviceOwnerDetailsdeviceId",
                table: "deviceInfoResponses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_deviceInfoResponses_deviceOwnerDetailsdeviceId",
                table: "deviceInfoResponses",
                column: "deviceOwnerDetailsdeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_deviceInfoResponses_deviceInfoResponses_deviceOwnerDetailsdeviceId",
                table: "deviceInfoResponses",
                column: "deviceOwnerDetailsdeviceId",
                principalTable: "deviceInfoResponses",
                principalColumn: "deviceId");
        }
    }
}
