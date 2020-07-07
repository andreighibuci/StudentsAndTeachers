using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsAndTeachers.Migrations
{
    public partial class ThirdMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Classes_ClassCourseid",
                table: "Homeworks");

            migrationBuilder.RenameColumn(
                name: "ClassCourseid",
                table: "Homeworks",
                newName: "classCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_ClassCourseid",
                table: "Homeworks",
                newName: "IX_Homeworks_classCourseId");

            migrationBuilder.AlterColumn<int>(
                name: "classCourseId",
                table: "Homeworks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Classes_classCourseId",
                table: "Homeworks",
                column: "classCourseId",
                principalTable: "Classes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Classes_classCourseId",
                table: "Homeworks");

            migrationBuilder.RenameColumn(
                name: "classCourseId",
                table: "Homeworks",
                newName: "ClassCourseid");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_classCourseId",
                table: "Homeworks",
                newName: "IX_Homeworks_ClassCourseid");

            migrationBuilder.AlterColumn<int>(
                name: "ClassCourseid",
                table: "Homeworks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Classes_ClassCourseid",
                table: "Homeworks",
                column: "ClassCourseid",
                principalTable: "Classes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
