using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASU.DTO.Migrations
{
    public partial class MeasureDevice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeasureDevices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AllowedByCat = table.Column<string>(nullable: true),
                    AllowedByClass = table.Column<string>(nullable: true),
                    AllowedByRandom = table.Column<string>(nullable: true),
                    MDProducer = table.Column<string>(nullable: true),
                    MDProductionDate = table.Column<string>(nullable: true),
                    MeasurmentRange = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    QualifiedName = table.Column<string>(nullable: true),
                    MeasurementTypeId = table.Column<int>(nullable: false),
                    VerificationGap = table.Column<int>(nullable: false),
                    MeasureDeviceTypeId = table.Column<int>(nullable: true),
                    VerificationProc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeasureDevices_MeasureDeviceTypes_MeasureDeviceTypeId",
                        column: x => x.MeasureDeviceTypeId,
                        principalTable: "MeasureDeviceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeasureDevices_MeasurementTypes_MeasurementTypeId",
                        column: x => x.MeasurementTypeId,
                        principalTable: "MeasurementTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeasureDevices_MeasureDeviceTypeId",
                table: "MeasureDevices",
                column: "MeasureDeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasureDevices_MeasurementTypeId",
                table: "MeasureDevices",
                column: "MeasurementTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeasureDevices");
        }
    }
}
