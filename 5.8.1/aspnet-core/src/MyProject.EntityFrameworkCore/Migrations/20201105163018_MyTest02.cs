using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.Migrations
{
    public partial class MyTest02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "test",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "test",
                newName: "Persons",
                newSchema: "test");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                schema: "test",
                table: "Persons",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                schema: "test",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                schema: "test",
                newName: "Users",
                newSchema: "test");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "test",
                table: "Users",
                column: "Id");
        }
    }
}
