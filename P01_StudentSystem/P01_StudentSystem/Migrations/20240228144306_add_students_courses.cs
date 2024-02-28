using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P01_StudentSystem.Migrations
{
    public partial class add_students_courses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "contentType",
                table: "homeworks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contentType",
                table: "homeworks");
        }
    }
}
