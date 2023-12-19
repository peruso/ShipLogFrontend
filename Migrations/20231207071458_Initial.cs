using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ship_Review.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ManagerName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.ManagerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OwnerName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShipInfos",
                columns: table => new
                {
                    ShipInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Imo = table.Column<uint>(type: "int unsigned", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Flag = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GrossTon = table.Column<uint>(type: "int unsigned", nullable: false),
                    Dwt = table.Column<uint>(type: "int unsigned", nullable: false),
                    Length = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    Beam = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    Draught = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Photo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BuildYear = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipInfos", x => x.ShipInfoId);
                    table.ForeignKey(
                        name: "FK_ShipInfos_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "ManagerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipInfos_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "OwnerId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CurrentVoyages",
                columns: table => new
                {
                    CurrentVoyageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Longitude = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Destination = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastPort = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ETA = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastUpdate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShipInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentVoyages", x => x.CurrentVoyageId);
                    table.ForeignKey(
                        name: "FK_CurrentVoyages_ShipInfos_ShipInfoId",
                        column: x => x.ShipInfoId,
                        principalTable: "ShipInfos",
                        principalColumn: "ShipInfoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShipEvaluations",
                columns: table => new
                {
                    ShipEvaluationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VesselQualityMin = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    VesselQualityMax = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    VesselQualityValue = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    CrewPerformanceMin = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    CrewPerformanceMax = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    CrewPerformanceValue = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    CrewAttitudeMin = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    CrewAttitudeMax = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    CrewAttitudeValue = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    FuelEfficiencyMin = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    FuelEfficiencyMax = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    FuelEfficiencyValue = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    SafetyScoreMin = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    SafetyScoreMax = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    SafetyScoreValue = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    ShipInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipEvaluations", x => x.ShipEvaluationId);
                    table.ForeignKey(
                        name: "FK_ShipEvaluations_ShipInfos_ShipInfoId",
                        column: x => x.ShipInfoId,
                        principalTable: "ShipInfos",
                        principalColumn: "ShipInfoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentVoyages_ShipInfoId",
                table: "CurrentVoyages",
                column: "ShipInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipEvaluations_ShipInfoId",
                table: "ShipEvaluations",
                column: "ShipInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipInfos_ManagerId",
                table: "ShipInfos",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipInfos_OwnerId",
                table: "ShipInfos",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentVoyages");

            migrationBuilder.DropTable(
                name: "ShipEvaluations");

            migrationBuilder.DropTable(
                name: "ShipInfos");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
