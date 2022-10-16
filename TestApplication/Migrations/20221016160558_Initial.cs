using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TestApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CatalogId = table.Column<int>(type: "integer", nullable: false),
                    RootFolderId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "CatalogId", "Name", "RootFolderId" },
                values: new object[,]
                {
                    { 1, 1, "Creating Digital Images", null },
                    { 2, 1, "Resources", 1 },
                    { 3, 1, "Evidence", 1 },
                    { 4, 1, "Graphic Products", 1 },
                    { 5, 1, "Primary Sources", 2 },
                    { 6, 1, "Secondary Sources", 2 },
                    { 7, 1, "Process", 4 },
                    { 8, 1, "Final Product", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Folders");
        }
    }
}
