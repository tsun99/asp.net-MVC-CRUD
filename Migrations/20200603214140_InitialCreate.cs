using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.netMVCCRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pavadinimas = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ElPastas = table.Column<string>(type: "varchar(150)", nullable: true),
                    BlogasElPastas = table.Column<string>(type: "varchar(150)", nullable: true),
                    TelNr = table.Column<string>(type: "varchar(100)", nullable: true),
                    Apskritis = table.Column<string>(type: "varchar(50)", nullable: true),
                    VMVT = table.Column<string>(type: "varchar(50)", nullable: true),
                    KitaInfo = table.Column<string>(type: "varchar(250)", nullable: true),
                    AktualiVeikla = table.Column<string>(type: "varchar(250)", nullable: true),
                    ImonesKodas = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imones");
        }
    }
}
