using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTimer.Data.Migrations
{
    public partial class ForeignKeyNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Categories_CategoryTaskCategoryID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CategoryTaskCategoryID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CategoryTaskCategoryID",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CategoryID",
                table: "Tasks",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Categories_CategoryID",
                table: "Tasks",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "TaskCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Categories_CategoryID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CategoryID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "CategoryTaskCategoryID",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CategoryTaskCategoryID",
                table: "Tasks",
                column: "CategoryTaskCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Categories_CategoryTaskCategoryID",
                table: "Tasks",
                column: "CategoryTaskCategoryID",
                principalTable: "Categories",
                principalColumn: "TaskCategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
