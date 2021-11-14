using Microsoft.EntityFrameworkCore.Migrations;

namespace Uned.RestWithEFExample.Migrations
{
    public partial class GuitarIsValid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Guitars",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Guitars");
        }
    }
}
