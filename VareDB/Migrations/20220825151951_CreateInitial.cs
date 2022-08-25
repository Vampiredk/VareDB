using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VareDB.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunde",
                columns: table => new
                {
                    Kunde_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNummer = table.Column<int>(type: "int", nullable: false),
                    Addresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postnummer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunde", x => x.Kunde_id);
                });

            migrationBuilder.CreateTable(
                name: "Ordre",
                columns: table => new
                {
                    Ordre_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kunde_id = table.Column<int>(type: "int", nullable: false),
                    Ordre_dato = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordre", x => x.Ordre_id);
                });

            migrationBuilder.CreateTable(
                name: "Ordre_vare",
                columns: table => new
                {
                    Ordre_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vare_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Antal = table.Column<int>(type: "int", nullable: false),
                    Pris = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordre_vare", x => x.Ordre_id);
                });

            migrationBuilder.CreateTable(
                name: "Postnummer",
                columns: table => new
                {
                    postnummmeer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hjemby = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postnummer", x => x.postnummmeer);
                });

            migrationBuilder.CreateTable(
                name: "vare",
                columns: table => new
                {
                    Vare_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pris = table.Column<int>(type: "int", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lager = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vare", x => x.Vare_id);
                });

            migrationBuilder.CreateTable(
                name: "vare_Type",
                columns: table => new
                {
                    Type = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vare_Type", x => x.Type);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kunde");

            migrationBuilder.DropTable(
                name: "Ordre");

            migrationBuilder.DropTable(
                name: "Ordre_vare");

            migrationBuilder.DropTable(
                name: "Postnummer");

            migrationBuilder.DropTable(
                name: "vare");

            migrationBuilder.DropTable(
                name: "vare_Type");
        }
    }
}
