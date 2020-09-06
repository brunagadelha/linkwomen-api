using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkWomen.Data.Migrations
{
    public partial class InsertDefaultTechSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TechSkills",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "C" },
                    { 15, "SQL" },
                    { 14, "Python" },
                    { 13, "Go" },
                    { 12, "Ruby" },
                    { 11, "Java" },
                    { 10, "React Native" },
                    { 16, "MySQL" },
                    { 9, "Node" },
                    { 7, "Kotlin" },
                    { 6, "Objective-C" },
                    { 5, "Swift" },
                    { 4, "JavaScript" },
                    { 3, "C#" },
                    { 2, "C++" },
                    { 8, "React" },
                    { 17, "MongoDB" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TechSkills",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
