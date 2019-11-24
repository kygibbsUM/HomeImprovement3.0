using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeImprovement3._0.Migrations
{
    public partial class UpdateDisply2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByID",
                table: "Project",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "Project");
        }
    }
}
