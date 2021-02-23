using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGA.Migrations
{
    public partial class AddResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeAtivo = table.Column<string>(nullable: true),
                    areaResponsavel = table.Column<string>(nullable: true),
                    dataEntrada = table.Column<DateTime>(nullable: false),
                    bLiquidado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resources");
        }
    }
}
