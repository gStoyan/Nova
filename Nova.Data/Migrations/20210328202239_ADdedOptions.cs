using Microsoft.EntityFrameworkCore.Migrations;

namespace Nova.Data.Migrations
{
    public partial class ADdedOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Option",
                table: "Texts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Option",
                table: "Texts");
        }
    }
}
