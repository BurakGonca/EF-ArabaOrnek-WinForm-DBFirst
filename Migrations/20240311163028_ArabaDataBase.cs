using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _7mart2024.Migrations
{
    /// <inheritdoc />
    public partial class ArabaDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Muhendisler",
                columns: table => new
                {
                    MuhendisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muhendisler", x => x.MuhendisID);
                });

            migrationBuilder.CreateTable(
                name: "Plakalar",
                columns: table => new
                {
                    PlakaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numara = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plakalar", x => x.PlakaID);
                });

            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlakaID = table.Column<int>(type: "int", nullable: false),
                    KisiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Arabalar_Kisiler_KisiID",
                        column: x => x.KisiID,
                        principalTable: "Kisiler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arabalar_Plakalar_PlakaID",
                        column: x => x.PlakaID,
                        principalTable: "Plakalar",
                        principalColumn: "PlakaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArabaMuhendis",
                columns: table => new
                {
                    ArabalarID = table.Column<int>(type: "int", nullable: false),
                    MuhendislerMuhendisID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaMuhendis", x => new { x.ArabalarID, x.MuhendislerMuhendisID });
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Arabalar_ArabalarID",
                        column: x => x.ArabalarID,
                        principalTable: "Arabalar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Muhendisler_MuhendislerMuhendisID",
                        column: x => x.MuhendislerMuhendisID,
                        principalTable: "Muhendisler",
                        principalColumn: "MuhendisID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_KisiID",
                table: "Arabalar",
                column: "KisiID");

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_PlakaID",
                table: "Arabalar",
                column: "PlakaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArabaMuhendis_MuhendislerMuhendisID",
                table: "ArabaMuhendis",
                column: "MuhendislerMuhendisID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArabaMuhendis");

            migrationBuilder.DropTable(
                name: "Arabalar");

            migrationBuilder.DropTable(
                name: "Muhendisler");

            migrationBuilder.DropTable(
                name: "Kisiler");

            migrationBuilder.DropTable(
                name: "Plakalar");
        }
    }
}
