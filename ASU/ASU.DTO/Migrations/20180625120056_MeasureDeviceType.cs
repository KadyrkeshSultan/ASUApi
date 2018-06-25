using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASU.DTO.Migrations
{
    public partial class MeasureDeviceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeasureDeviceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AllowedByCat = table.Column<string>(nullable: true),
                    AllowedByClass = table.Column<string>(nullable: true),
                    AllowedByRandom = table.Column<string>(nullable: true),
                    MDProducer = table.Column<string>(nullable: true),
                    MeasurmentRange = table.Column<string>(nullable: true),
                    QualifiedName = table.Column<string>(nullable: true),
                    MeasurementTypeId = table.Column<int>(nullable: false),
                    VerificationGap = table.Column<int>(nullable: false),
                    VerificationProc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureDeviceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeasureDeviceTypes_MeasurementTypes_MeasurementTypeId",
                        column: x => x.MeasurementTypeId,
                        principalTable: "MeasurementTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeasureDeviceTypes_MeasurementTypeId",
                table: "MeasureDeviceTypes",
                column: "MeasurementTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeasureDeviceTypes");
        }
    }
}
