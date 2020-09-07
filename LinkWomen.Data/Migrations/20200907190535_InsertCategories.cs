using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkWomen.Data.Migrations
{
    public partial class InsertCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Representatividade" },
                    { 2, "LGBT+" },
                    { 3, "Vagas" },
                    { 4, "Tech" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ForumCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ForumCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ForumCategories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
