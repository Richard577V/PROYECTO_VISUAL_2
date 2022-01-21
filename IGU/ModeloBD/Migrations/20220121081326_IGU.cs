using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloBD.Migrations
{
    public partial class IGU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotaGrados",
                columns: table => new
                {
                    NotaGradoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nota1 = table.Column<float>(type: "real", nullable: false),
                    estudianteid = table.Column<int>(type: "int", nullable: false),
                    NotaPruebaId = table.Column<int>(type: "int", nullable: true),
                    PruebaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaGrados", x => x.NotaGradoId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    estudianteid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotaPruebaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.estudianteid);
                });

            migrationBuilder.CreateTable(
                name: "Pruebas",
                columns: table => new
                {
                    PruebaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    materia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nota1 = table.Column<float>(type: "real", nullable: false),
                    Nota2 = table.Column<float>(type: "real", nullable: false),
                    Nota3 = table.Column<float>(type: "real", nullable: false),
                    Nota4 = table.Column<float>(type: "real", nullable: false),
                    NotaPruebaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pruebas", x => x.PruebaId);
                });

            migrationBuilder.CreateTable(
                name: "NotaPruebas",
                columns: table => new
                {
                    NotaPruebaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PruebaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaPruebas", x => x.NotaPruebaId);
                    table.ForeignKey(
                        name: "FK_NotaPruebas_Pruebas_PruebaId",
                        column: x => x.PruebaId,
                        principalTable: "Pruebas",
                        principalColumn: "PruebaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_NotaPruebaId",
                table: "Estudiantes",
                column: "NotaPruebaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaGrados_estudianteid",
                table: "NotaGrados",
                column: "estudianteid");

            migrationBuilder.CreateIndex(
                name: "IX_NotaGrados_NotaPruebaId",
                table: "NotaGrados",
                column: "NotaPruebaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaGrados_PruebaId",
                table: "NotaGrados",
                column: "PruebaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaPruebas_PruebaId",
                table: "NotaPruebas",
                column: "PruebaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pruebas_NotaPruebaId",
                table: "Pruebas",
                column: "NotaPruebaId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaGrados_Estudiantes_estudianteid",
                table: "NotaGrados",
                column: "estudianteid",
                principalTable: "Estudiantes",
                principalColumn: "estudianteid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaGrados_NotaPruebas_NotaPruebaId",
                table: "NotaGrados",
                column: "NotaPruebaId",
                principalTable: "NotaPruebas",
                principalColumn: "NotaPruebaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaGrados_Pruebas_PruebaId",
                table: "NotaGrados",
                column: "PruebaId",
                principalTable: "Pruebas",
                principalColumn: "PruebaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_NotaPruebas_NotaPruebaId",
                table: "Estudiantes",
                column: "NotaPruebaId",
                principalTable: "NotaPruebas",
                principalColumn: "NotaPruebaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pruebas_NotaPruebas_NotaPruebaId",
                table: "Pruebas",
                column: "NotaPruebaId",
                principalTable: "NotaPruebas",
                principalColumn: "NotaPruebaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pruebas_NotaPruebas_NotaPruebaId",
                table: "Pruebas");

            migrationBuilder.DropTable(
                name: "NotaGrados");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "NotaPruebas");

            migrationBuilder.DropTable(
                name: "Pruebas");
        }
    }
}
