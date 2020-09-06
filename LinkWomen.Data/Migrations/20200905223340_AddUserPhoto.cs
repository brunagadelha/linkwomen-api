using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkWomen.Data.Migrations
{
    public partial class AddUserPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumIssues_ForumCategories_CategoryId",
                table: "ForumIssues");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Users",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Users",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "ForumIssues",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumIssues_ForumCategories_CategoryId",
                table: "ForumIssues",
                column: "CategoryId",
                principalTable: "ForumCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumIssues_ForumCategories_CategoryId",
                table: "ForumIssues");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Users",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "ForumIssues",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumIssues_ForumCategories_CategoryId",
                table: "ForumIssues",
                column: "CategoryId",
                principalTable: "ForumCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
