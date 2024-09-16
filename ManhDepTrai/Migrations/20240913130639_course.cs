using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManhDepTrai.Migrations
{
    public partial class course : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "BangTrungGian",
                columns: table => new
                {
                    CoursesCourseId = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangTrungGian", x => new { x.CoursesCourseId, x.StudentsStudentID });
                    table.ForeignKey(
                        name: "FK_BangTrungGian_courses_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BangTrungGian_SinhVien_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "SinhVien",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BangTrungGian_StudentsStudentID",
                table: "BangTrungGian",
                column: "StudentsStudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangTrungGian");

            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
