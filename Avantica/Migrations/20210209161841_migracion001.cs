using Microsoft.EntityFrameworkCore.Migrations;

namespace Avantica.Migrations
{
    public partial class migracion001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Properties",
                schema: "dbo",
                columns: table => new
                {
                    Address = table.Column<string>(nullable: false),
                    Year_Built = table.Column<int>(nullable: true),
                    List_Price = table.Column<string>(nullable: true),
                    Monthly_Rent = table.Column<string>(nullable: true),
                    Gross_Yield = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Address);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties",
                schema: "dbo");
        }
    }
}
