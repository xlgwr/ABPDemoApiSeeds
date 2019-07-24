using Microsoft.EntityFrameworkCore.Migrations;

namespace FHCollection.ApiCore.Migrations
{
    public partial class book2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "FH_Books");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "FH_Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "FH_Books",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "FH_Books",
                nullable: true);
        }
    }
}
