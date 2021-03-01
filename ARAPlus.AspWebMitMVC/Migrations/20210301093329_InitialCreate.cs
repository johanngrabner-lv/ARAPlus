using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ARAPlus.AspWebMitMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stichprobe",
                columns: table => new
                {
                    StichprobeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abgabedatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gefahrengut = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stichprobe", x => x.StichprobeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stichprobe");
        }
    }
}
