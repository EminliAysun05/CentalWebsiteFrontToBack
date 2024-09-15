using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CentalWebsiteFrontToBack.Migrations
{
    public partial class HomeTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Bios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FbLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IgLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YtLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LnLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwitterLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Homes");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Bios");
        }
    }
}
