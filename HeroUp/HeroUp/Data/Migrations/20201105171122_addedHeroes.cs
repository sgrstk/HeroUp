using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroUp.Data.Migrations
{
    public partial class addedHeroes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    MP = table.Column<int>(nullable: false),
                    Power = table.Column<int>(nullable: false),
                    Agility = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    HeroCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
