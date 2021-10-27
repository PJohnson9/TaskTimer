using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTimer.Data.Migrations
{
    public partial class TableRenames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskCategories_CategoryTaskCategoryID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkSessions_Tasks_TaskID",
                table: "WorkSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkSessions",
                table: "WorkSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskCategories",
                table: "TaskCategories");

            migrationBuilder.RenameTable(
                name: "WorkSessions",
                newName: "Sessions");

            migrationBuilder.RenameTable(
                name: "TaskCategories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_WorkSessions_TaskID",
                table: "Sessions",
                newName: "IX_Sessions_TaskID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "End",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions",
                column: "SessionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "TaskCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Tasks_TaskID",
                table: "Sessions",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "TaskID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Categories_CategoryTaskCategoryID",
                table: "Tasks",
                column: "CategoryTaskCategoryID",
                principalTable: "Categories",
                principalColumn: "TaskCategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Tasks_TaskID",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Categories_CategoryTaskCategoryID",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Sessions",
                newName: "WorkSessions");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "TaskCategories");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_TaskID",
                table: "WorkSessions",
                newName: "IX_WorkSessions_TaskID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "End",
                table: "WorkSessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkSessions",
                table: "WorkSessions",
                column: "SessionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskCategories",
                table: "TaskCategories",
                column: "TaskCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskCategories_CategoryTaskCategoryID",
                table: "Tasks",
                column: "CategoryTaskCategoryID",
                principalTable: "TaskCategories",
                principalColumn: "TaskCategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkSessions_Tasks_TaskID",
                table: "WorkSessions",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "TaskID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
