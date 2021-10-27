using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTimer.Data.Migrations
{
    public partial class TaskTimerSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Tasks",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "Sessions",
                newName: "Sessions",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categories",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "AspNetUserTokens",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "AspNetUsers",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "AspNetUserRoles",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "AspNetUserLogins",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "AspNetUserClaims",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "AspNetRoles",
                newSchema: "TaskTimer");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "AspNetRoleClaims",
                newSchema: "TaskTimer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Tasks",
                schema: "TaskTimer",
                newName: "Tasks");

            migrationBuilder.RenameTable(
                name: "Sessions",
                schema: "TaskTimer",
                newName: "Sessions");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "TaskTimer",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "TaskTimer",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "TaskTimer",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "TaskTimer",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "TaskTimer",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "TaskTimer",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "TaskTimer",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "TaskTimer",
                newName: "AspNetRoleClaims");
        }
    }
}
