using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ship_Review.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShipInfos_Managers_ManagerId",
                table: "ShipInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipInfos_Owners_OwnerId",
                table: "ShipInfos");

            migrationBuilder.DropTable(
                name: "CurrentVoyages");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_ShipInfos_ManagerId",
                table: "ShipInfos");

            migrationBuilder.DropIndex(
                name: "IX_ShipInfos_OwnerId",
                table: "ShipInfos");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "ShipInfos");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "ShipInfos");

            migrationBuilder.AddColumn<string>(
                name: "Manager",
                table: "ShipInfos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "ShipInfos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manager",
                table: "ShipInfos");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "ShipInfos");

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "ShipInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "ShipInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CurrentVoyages",
                columns: table => new
                {
                    CurrentVoyageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShipInfoId = table.Column<int>(type: "int", nullable: false),
                    Destination = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ETA = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastPort = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastUpdate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Latitude = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_ShipInfos_ManagerId",
                table: "ShipInfos",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipInfos_OwnerId",
                table: "ShipInfos",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentVoyages_ShipInfoId",
                table: "CurrentVoyages",
                column: "ShipInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShipInfos_Managers_ManagerId",
                table: "ShipInfos",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipInfos_Owners_OwnerId",
                table: "ShipInfos",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
