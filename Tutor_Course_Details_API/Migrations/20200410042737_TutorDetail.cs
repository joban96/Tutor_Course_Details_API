using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace Tutor_Course_Details_API.Migrations
{
    public partial class TutorDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TutorDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TutorName = table.Column<string>(nullable: true),
                    DepartmentName = table.Column<string>(nullable: true),
                    CourseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorDetails", x => x.Id);
                });
            var sqlFile = Path.Combine(".\\DatabaseScript", @"DataQueries.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TutorDetails");
        }
    }
}
