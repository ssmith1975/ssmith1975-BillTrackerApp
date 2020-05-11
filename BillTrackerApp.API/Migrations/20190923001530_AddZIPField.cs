using Microsoft.EntityFrameworkCore.Migrations;

namespace BillTrackerApp.API.Migrations
{
    public partial class AddZIPField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "Address",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Address");
        }
    }
}
