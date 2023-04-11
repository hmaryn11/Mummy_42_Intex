using Microsoft.EntityFrameworkCore.Migrations;

namespace Mummy_42_Intex.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artifacts",
                columns: table => new
                {
                    ArtifactId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    CurrentLocation = table.Column<string>(nullable: true),
                    StorageLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artifacts", x => x.ArtifactId);
                });

            migrationBuilder.InsertData(
                table: "Artifacts",
                columns: new[] { "ArtifactId", "CurrentLocation", "Date", "Description", "Dimensions", "Material", "StorageLocation" },
                values: new object[] { 1, "Rio", "2022-01-13", "Big and scary", "6 ft", "Spikes", "Chicago" });

            migrationBuilder.InsertData(
                table: "Artifacts",
                columns: new[] { "ArtifactId", "CurrentLocation", "Date", "Description", "Dimensions", "Material", "StorageLocation" },
                values: new object[] { 2, "Spain", "2022-04-30", "Small and fluffy", "8 in", "Cotton", "Chicago" });

            migrationBuilder.InsertData(
                table: "Artifacts",
                columns: new[] { "ArtifactId", "CurrentLocation", "Date", "Description", "Dimensions", "Material", "StorageLocation" },
                values: new object[] { 3, "Rio", "2022-01-13", "Big and scary", "6 ft", "Spikes", "Chicago" });

            migrationBuilder.InsertData(
                table: "Artifacts",
                columns: new[] { "ArtifactId", "CurrentLocation", "Date", "Description", "Dimensions", "Material", "StorageLocation" },
                values: new object[] { 4, "Spain", "2022-04-30", "Small and fluffy", "8 in", "Cotton", "Chicago" });

            migrationBuilder.InsertData(
                table: "Artifacts",
                columns: new[] { "ArtifactId", "CurrentLocation", "Date", "Description", "Dimensions", "Material", "StorageLocation" },
                values: new object[] { 5, "Rio", "2022-01-13", "Big and scary", "6 ft", "Spikes", "Chicago" });

            migrationBuilder.InsertData(
                table: "Artifacts",
                columns: new[] { "ArtifactId", "CurrentLocation", "Date", "Description", "Dimensions", "Material", "StorageLocation" },
                values: new object[] { 6, "Spain", "2022-04-30", "Small and fluffy", "8 in", "Cotton", "Chicago" });

            migrationBuilder.InsertData(
                table: "Artifacts",
                columns: new[] { "ArtifactId", "CurrentLocation", "Date", "Description", "Dimensions", "Material", "StorageLocation" },
                values: new object[] { 7, "Rio", "2022-01-13", "Big and scary", "6 ft", "Spikes", "Chicago" });

            migrationBuilder.InsertData(
                table: "Artifacts",
                columns: new[] { "ArtifactId", "CurrentLocation", "Date", "Description", "Dimensions", "Material", "StorageLocation" },
                values: new object[] { 8, "Spain", "2022-04-30", "Small and fluffy", "8 in", "Cotton", "Chicago" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artifacts");
        }
    }
}
