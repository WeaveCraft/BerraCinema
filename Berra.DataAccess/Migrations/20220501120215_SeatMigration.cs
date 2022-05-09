using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Berra.DataAccess.Migrations
{
    public partial class SeatMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "Seats",
                table: "MenuItem",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seats",
                table: "MenuItem");
        }
    }
}
