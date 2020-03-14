using Microsoft.EntityFrameworkCore.Migrations;

namespace Apartments.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Meters = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Floor = table.Column<int>(nullable: false),
                    Construction = table.Column<string>(nullable: true),
                    Electricity = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartments");
        }
    }
}
