using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOrigoTask.Data.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_deviceInfoResponses_LeasingPeriodsComputed_leasingPeriodsComputedleasingConstructionId",
                table: "deviceInfoResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeasingPeriodsComputed",
                table: "LeasingPeriodsComputed");

            migrationBuilder.RenameTable(
                name: "LeasingPeriodsComputed",
                newName: "LeasingPeriodsComputeds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeasingPeriodsComputeds",
                table: "LeasingPeriodsComputeds",
                column: "leasingConstructionId");

            migrationBuilder.CreateTable(
                name: "DeviceOwnerDetails",
                columns: table => new
                {
                    billing_name = table.Column<string>(type: "TEXT", nullable: false),
                    adress_country = table.Column<string>(type: "TEXT", nullable: false),
                    address_zip = table.Column<string>(type: "TEXT", nullable: false),
                    address_city = table.Column<string>(type: "TEXT", nullable: false),
                    address_street = table.Column<string>(type: "TEXT", nullable: false),
                    vat_number = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceOwnerDetails", x => x.billing_name);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_deviceInfoResponses_LeasingPeriodsComputeds_leasingPeriodsComputedleasingConstructionId",
                table: "deviceInfoResponses",
                column: "leasingPeriodsComputedleasingConstructionId",
                principalTable: "LeasingPeriodsComputeds",
                principalColumn: "leasingConstructionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_deviceInfoResponses_LeasingPeriodsComputeds_leasingPeriodsComputedleasingConstructionId",
                table: "deviceInfoResponses");

            migrationBuilder.DropTable(
                name: "DeviceOwnerDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeasingPeriodsComputeds",
                table: "LeasingPeriodsComputeds");

            migrationBuilder.RenameTable(
                name: "LeasingPeriodsComputeds",
                newName: "LeasingPeriodsComputed");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeasingPeriodsComputed",
                table: "LeasingPeriodsComputed",
                column: "leasingConstructionId");

            migrationBuilder.AddForeignKey(
                name: "FK_deviceInfoResponses_LeasingPeriodsComputed_leasingPeriodsComputedleasingConstructionId",
                table: "deviceInfoResponses",
                column: "leasingPeriodsComputedleasingConstructionId",
                principalTable: "LeasingPeriodsComputed",
                principalColumn: "leasingConstructionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
