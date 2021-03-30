using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularTestSeparate.Migrations
{
    public partial class AddedStopRefNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefNumber",
                table: "Stop",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefNumber",
                table: "Stop");
        }
    }
}
