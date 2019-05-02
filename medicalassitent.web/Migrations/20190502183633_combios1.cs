using Microsoft.EntityFrameworkCore.Migrations;

namespace medicalassitent.web.Migrations
{
    public partial class combios1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "WasDeleted",
                table: "DocumentTypes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WasDeleted",
                table: "DocumentTypes");
        }
    }
}
