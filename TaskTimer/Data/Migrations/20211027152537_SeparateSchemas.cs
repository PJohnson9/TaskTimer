using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTimer.Data.Migrations
{
    public partial class SeparateSchemas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Tasks_TaskID",
                schema: "TaskTimer",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Categories_CategoryID",
                schema: "TaskTimer",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                schema: "TaskTimer",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessions",
                schema: "TaskTimer",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                schema: "TaskTimer",
                table: "Categories");

            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "TaskTimer",
                newName: "AspNetUserTokens",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "TaskTimer",
                newName: "AspNetUsers",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "TaskTimer",
                newName: "AspNetUserRoles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "TaskTimer",
                newName: "AspNetUserLogins",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "TaskTimer",
                newName: "AspNetUserClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "TaskTimer",
                newName: "AspNetRoles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "TaskTimer",
                newName: "AspNetRoleClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Tasks",
                schema: "TaskTimer",
                newName: "Task",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "Sessions",
                schema: "TaskTimer",
                newName: "Session",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "TaskTimer",
                newName: "Category",
                newSchema: "TaskTimer");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_CategoryID",
                schema: "TaskTimer",
                table: "Task",
                newName: "IX_Task_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_TaskID",
                schema: "TaskTimer",
                table: "Session",
                newName: "IX_Session_TaskID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Task",
                schema: "TaskTimer",
                table: "Task",
                column: "TaskID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Session",
                schema: "TaskTimer",
                table: "Session",
                column: "SessionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                schema: "TaskTimer",
                table: "Category",
                column: "TaskCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Task_TaskID",
                schema: "TaskTimer",
                table: "Session",
                column: "TaskID",
                principalSchema: "TaskTimer",
                principalTable: "Task",
                principalColumn: "TaskID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Category_CategoryID",
                schema: "TaskTimer",
                table: "Task",
                column: "CategoryID",
                principalSchema: "TaskTimer",
                principalTable: "Category",
                principalColumn: "TaskCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Session_Task_TaskID",
                schema: "TaskTimer",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Category_CategoryID",
                schema: "TaskTimer",
                table: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Task",
                schema: "TaskTimer",
                table: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Session",
                schema: "TaskTimer",
                table: "Session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                schema: "TaskTimer",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "Identity",
                newName: "AspNetUserTokens",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "Identity",
                newName: "AspNetUsers",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "Identity",
                newName: "AspNetUserRoles",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "Identity",
                newName: "AspNetUserLogins",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "Identity",
                newName: "AspNetUserClaims",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "Identity",
                newName: "AspNetRoles",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "Identity",
                newName: "AspNetRoleClaims",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "Task",
                schema: "TaskTimer",
                newName: "Tasks",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "Session",
                schema: "TaskTimer",
                newName: "Sessions",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "Category",
                schema: "TaskTimer",
                newName: "Categories",
                newSchema: "TaskTimer");

            migrationBuilder.RenameIndex(
                name: "IX_Task_CategoryID",
                schema: "TaskTimer",
                table: "Tasks",
                newName: "IX_Tasks_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TaskID",
                schema: "TaskTimer",
                table: "Sessions",
                newName: "IX_Sessions_TaskID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                schema: "TaskTimer",
                table: "Tasks",
                column: "TaskID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessions",
                schema: "TaskTimer",
                table: "Sessions",
                column: "SessionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                schema: "TaskTimer",
                table: "Categories",
                column: "TaskCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Tasks_TaskID",
                schema: "TaskTimer",
                table: "Sessions",
                column: "TaskID",
                principalSchema: "TaskTimer",
                principalTable: "Tasks",
                principalColumn: "TaskID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Categories_CategoryID",
                schema: "TaskTimer",
                table: "Tasks",
                column: "CategoryID",
                principalSchema: "TaskTimer",
                principalTable: "Categories",
                principalColumn: "TaskCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
