using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsAndTeachers.Migrations
{
    public partial class fthMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Classes_classCourseId",
                table: "Homeworks");

            migrationBuilder.RenameColumn(
                name: "classCourseId",
                table: "Homeworks",
                newName: "classCourseid");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_classCourseId",
                table: "Homeworks",
                newName: "IX_Homeworks_classCourseid");

            migrationBuilder.AlterColumn<int>(
                name: "classCourseid",
                table: "Homeworks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Classes_classCourseid",
                table: "Homeworks",
                column: "classCourseid",
                principalTable: "Classes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Classes_classCourseid",
                table: "Homeworks");

            migrationBuilder.RenameColumn(
                name: "classCourseid",
                table: "Homeworks",
                newName: "classCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_classCourseid",
                table: "Homeworks",
                newName: "IX_Homeworks_classCourseId");

            migrationBuilder.AlterColumn<int>(
                name: "classCourseId",
                table: "Homeworks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Classes_classCourseId",
                table: "Homeworks",
                column: "classCourseId",
                principalTable: "Classes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
