using Microsoft.EntityFrameworkCore.Migrations;

namespace Nova.Data.Migrations
{
    public partial class AddedArmyToNova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Armies_ArmyId",
                table: "Unit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unit",
                table: "Unit");

            migrationBuilder.RenameTable(
                name: "Unit",
                newName: "Units");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_ArmyId",
                table: "Units",
                newName: "IX_Units_ArmyId");

            migrationBuilder.AddColumn<int>(
                name: "NovaModelId",
                table: "Armies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "NovaModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttackPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArmorPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealethPoints = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NovaModels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armies_NovaModelId",
                table: "Armies",
                column: "NovaModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Armies_NovaModels_NovaModelId",
                table: "Armies",
                column: "NovaModelId",
                principalTable: "NovaModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Armies_ArmyId",
                table: "Units",
                column: "ArmyId",
                principalTable: "Armies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armies_NovaModels_NovaModelId",
                table: "Armies");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_Armies_ArmyId",
                table: "Units");

            migrationBuilder.DropTable(
                name: "NovaModels");

            migrationBuilder.DropIndex(
                name: "IX_Armies_NovaModelId",
                table: "Armies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "NovaModelId",
                table: "Armies");

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "Unit");

            migrationBuilder.RenameIndex(
                name: "IX_Units_ArmyId",
                table: "Unit",
                newName: "IX_Unit_ArmyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unit",
                table: "Unit",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Armies_ArmyId",
                table: "Unit",
                column: "ArmyId",
                principalTable: "Armies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
