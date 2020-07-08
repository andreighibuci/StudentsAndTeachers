using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsAndTeachers.Migrations
{
    public partial class addedclasstostreammessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StreamMessages_Classes_ClassCourseid",
                table: "StreamMessages");

            migrationBuilder.RenameColumn(
                name: "ClassCourseid",
                table: "StreamMessages",
                newName: "classCourseid");

            migrationBuilder.RenameIndex(
                name: "IX_StreamMessages_ClassCourseid",
                table: "StreamMessages",
                newName: "IX_StreamMessages_classCourseid");

            migrationBuilder.AddForeignKey(
                name: "FK_StreamMessages_Classes_classCourseid",
                table: "StreamMessages",
                column: "classCourseid",
                principalTable: "Classes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StreamMessages_Classes_classCourseid",
                table: "StreamMessages");

            migrationBuilder.RenameColumn(
                name: "classCourseid",
                table: "StreamMessages",
                newName: "ClassCourseid");

            migrationBuilder.RenameIndex(
                name: "IX_StreamMessages_classCourseid",
                table: "StreamMessages",
                newName: "IX_StreamMessages_ClassCourseid");

            migrationBuilder.AddForeignKey(
                name: "FK_StreamMessages_Classes_ClassCourseid",
                table: "StreamMessages",
                column: "ClassCourseid",
                principalTable: "Classes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
