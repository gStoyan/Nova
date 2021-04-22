using Microsoft.EntityFrameworkCore.Migrations;

namespace Nova.Data.Migrations
{
    public partial class AddedTextsToNovaMOdel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NovaModelId",
                table: "Texts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Texts_NovaModelId",
                table: "Texts",
                column: "NovaModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Texts_NovaModels_NovaModelId",
                table: "Texts",
                column: "NovaModelId",
                principalTable: "NovaModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Texts_NovaModels_NovaModelId",
                table: "Texts");

            migrationBuilder.DropIndex(
                name: "IX_Texts_NovaModelId",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "NovaModelId",
                table: "Texts");
        }
    }
}
