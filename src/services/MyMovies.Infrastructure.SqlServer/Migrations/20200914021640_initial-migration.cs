using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMovies.Infrastructure.SqlServer.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(type: "varchar(55)", nullable: false),
                    Text = table.Column<string>(type: "varchar(255)", nullable: false),
                    Release = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
