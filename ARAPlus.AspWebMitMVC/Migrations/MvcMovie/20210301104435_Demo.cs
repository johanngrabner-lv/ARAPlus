using Microsoft.EntityFrameworkCore.Migrations;

namespace ARAPlus.AspWebMitMVC.Migrations.MvcMovie
{
    public partial class Demo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Demo",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Demo",
                table: "Movie");
        }
    }
}
