using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularTestSeparate.Migrations
{
    public partial class StopTypeRefTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StopTypeId",
                table: "Stop",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateTable(
                name: "StopTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StopTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Pickup" });

            migrationBuilder.InsertData(
                table: "StopTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Delivery" });

            migrationBuilder.CreateIndex(
                name: "IX_Stop_StopTypeId",
                table: "Stop",
                column: "StopTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stop_StopTypes_StopTypeId",
                table: "Stop",
                column: "StopTypeId",
                principalTable: "StopTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stop_StopTypes_StopTypeId",
                table: "Stop");

            migrationBuilder.DropTable(
                name: "StopTypes");

            migrationBuilder.DropIndex(
                name: "IX_Stop_StopTypeId",
                table: "Stop");

            migrationBuilder.DropColumn(
                name: "StopTypeId",
                table: "Stop");
        }
    }
}
