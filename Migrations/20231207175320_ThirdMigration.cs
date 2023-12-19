using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ship_Review.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShipEvaluations_ShipInfos_ShipInfoId",
                table: "ShipEvaluations");

            migrationBuilder.RenameColumn(
                name: "ShipInfoId",
                table: "ShipEvaluations",
                newName: "Imo");

            migrationBuilder.RenameIndex(
                name: "IX_ShipEvaluations_ShipInfoId",
                table: "ShipEvaluations",
                newName: "IX_ShipEvaluations_Imo");

            migrationBuilder.AlterColumn<int>(
                name: "Imo",
                table: "ShipInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int unsigned");

            migrationBuilder.AddForeignKey(
                name: "FK_ShipEvaluations_ShipInfos_Imo",
                table: "ShipEvaluations",
                column: "Imo",
                principalTable: "ShipInfos",
                principalColumn: "ShipInfoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShipEvaluations_ShipInfos_Imo",
                table: "ShipEvaluations");

            migrationBuilder.RenameColumn(
                name: "Imo",
                table: "ShipEvaluations",
                newName: "ShipInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipEvaluations_Imo",
                table: "ShipEvaluations",
                newName: "IX_ShipEvaluations_ShipInfoId");

            migrationBuilder.AlterColumn<uint>(
                name: "Imo",
                table: "ShipInfos",
                type: "int unsigned",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ShipEvaluations_ShipInfos_ShipInfoId",
                table: "ShipEvaluations",
                column: "ShipInfoId",
                principalTable: "ShipInfos",
                principalColumn: "ShipInfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
