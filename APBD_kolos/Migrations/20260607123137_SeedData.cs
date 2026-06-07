using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APBD_kolos.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Budget", "FacilityBuilding", "Name" },
                values: new object[] { 1, 100000m, "K101", "Informatyka" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "EnrollmentYear", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "jan@mail.to", 2022, "Jan", "Kowalski" },
                    { 2, "zygzak@mail.to", 2022, "Dawid", "Zygzak" }
                });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "ProfessorId", "DepartmentId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "smok@mail.to", "Jacek", "Smok" },
                    { 2, 1, "smok@mail.to", "Mark", "Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Credits", "ProfessorId", "Semester", "Title" },
                values: new object[] { 1, 3, 1, 1, "Programowanie obiektowe" });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "CourseId", "StudentId", "Grade", "Status" },
                values: new object[,]
                {
                    { 1, 1, 4.5m, "Approved" },
                    { 1, 2, 4m, "Approved" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "ProfessorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "ProfessorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);
        }
    }
}
