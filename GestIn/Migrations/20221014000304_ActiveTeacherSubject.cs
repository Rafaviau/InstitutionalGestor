using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestIn.Migrations
{
    public partial class ActiveTeacherSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Teacher");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "TeacherSubject",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "TeacherSubject");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Teacher",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
