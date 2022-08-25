using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOrigoTask.Data.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeasingPeriods",
                columns: table => new
                {
                    leasingConstructionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    leasingConstructionMaximumTraining = table.Column<int>(type: "INTEGER", nullable: false),
                    leasingConstructionMaximumDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeasingPeriods", x => x.leasingConstructionId);
                });

            migrationBuilder.CreateTable(
                name: "LeasingPeriodsComputed",
                columns: table => new
                {
                    leasingConstructionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    leasingConstructionMaximumTraining = table.Column<int>(type: "INTEGER", nullable: false),
                    leasingConstructionMaximumDate = table.Column<string>(type: "TEXT", nullable: false),
                    leasingActualPeriodStartDate = table.Column<string>(type: "TEXT", nullable: false),
                    leasingNextCheck = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeasingPeriodsComputed", x => x.leasingConstructionId);
                });

            migrationBuilder.CreateTable(
                name: "deviceInfoResponses",
                columns: table => new
                {
                    deviceId = table.Column<string>(type: "TEXT", nullable: false),
                    deviceType = table.Column<string>(type: "TEXT", nullable: false),
                    deviceOwner = table.Column<string>(type: "TEXT", nullable: false),
                    deviceOwnerDetailsdeviceId = table.Column<string>(type: "TEXT", nullable: true),
                    dateOfRegistration = table.Column<string>(type: "TEXT", nullable: false),
                    leasingPeriodsComputedleasingConstructionId = table.Column<int>(type: "INTEGER", nullable: false),
                    leasingPeriodsleasingConstructionId = table.Column<int>(type: "INTEGER", nullable: false),
                    timestamp = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deviceInfoResponses", x => x.deviceId);
                    table.ForeignKey(
                        name: "FK_deviceInfoResponses_deviceInfoResponses_deviceOwnerDetailsdeviceId",
                        column: x => x.deviceOwnerDetailsdeviceId,
                        principalTable: "deviceInfoResponses",
                        principalColumn: "deviceId");
                    table.ForeignKey(
                        name: "FK_deviceInfoResponses_LeasingPeriods_leasingPeriodsleasingConstructionId",
                        column: x => x.leasingPeriodsleasingConstructionId,
                        principalTable: "LeasingPeriods",
                        principalColumn: "leasingConstructionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_deviceInfoResponses_LeasingPeriodsComputed_leasingPeriodsComputedleasingConstructionId",
                        column: x => x.leasingPeriodsComputedleasingConstructionId,
                        principalTable: "LeasingPeriodsComputed",
                        principalColumn: "leasingConstructionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_deviceInfoResponses_deviceOwnerDetailsdeviceId",
                table: "deviceInfoResponses",
                column: "deviceOwnerDetailsdeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_deviceInfoResponses_leasingPeriodsComputedleasingConstructionId",
                table: "deviceInfoResponses",
                column: "leasingPeriodsComputedleasingConstructionId");

            migrationBuilder.CreateIndex(
                name: "IX_deviceInfoResponses_leasingPeriodsleasingConstructionId",
                table: "deviceInfoResponses",
                column: "leasingPeriodsleasingConstructionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "deviceInfoResponses");

            migrationBuilder.DropTable(
                name: "LeasingPeriods");

            migrationBuilder.DropTable(
                name: "LeasingPeriodsComputed");
        }
    }
}
