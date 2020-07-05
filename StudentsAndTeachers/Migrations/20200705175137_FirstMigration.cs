using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsAndTeachers.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    grade = table.Column<int>(nullable: false),
                    deadline = table.Column<DateTime>(nullable: false),
                    ClassCourseid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeworks", x => x.id);
                    table.ForeignKey(
                        name: "FK_Homeworks_Classes_ClassCourseid",
                        column: x => x.ClassCourseid,
                        principalTable: "Classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StreamMessages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    message = table.Column<string>(nullable: true),
                    dateTime = table.Column<DateTime>(nullable: false),
                    ClassCourseid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreamMessages", x => x.id);
                    table.ForeignKey(
                        name: "FK_StreamMessages_Classes_ClassCourseid",
                        column: x => x.ClassCourseid,
                        principalTable: "Classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comment = table.Column<string>(nullable: true),
                    Homeworkid = table.Column<int>(nullable: true),
                    StreamMessageid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comment_Homeworks_Homeworkid",
                        column: x => x.Homeworkid,
                        principalTable: "Homeworks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_StreamMessages_StreamMessageid",
                        column: x => x.StreamMessageid,
                        principalTable: "StreamMessages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_Homeworkid",
                table: "Comment",
                column: "Homeworkid");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_StreamMessageid",
                table: "Comment",
                column: "StreamMessageid");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_ClassCourseid",
                table: "Homeworks",
                column: "ClassCourseid");

            migrationBuilder.CreateIndex(
                name: "IX_StreamMessages_ClassCourseid",
                table: "StreamMessages",
                column: "ClassCourseid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.DropTable(
                name: "StreamMessages");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
