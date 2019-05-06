using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicalassitent.web.Migrations
{
    public partial class AddMedicalhistoriesModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicalhistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_Paciente = table.Column<int>(nullable: false),
                    Motivo_Consulta = table.Column<string>(nullable: true),
                    Antecedente_Hereditario = table.Column<string>(nullable: true),
                    Antecedente_Alergico = table.Column<string>(nullable: true),
                    Antecedente_Quirurjicos = table.Column<string>(nullable: true),
                    Revision_Sistema = table.Column<string>(nullable: true),
                    Cabeza = table.Column<string>(nullable: true),
                    Cuello = table.Column<string>(nullable: true),
                    Torax = table.Column<string>(nullable: true),
                    Abdomen = table.Column<string>(nullable: true),
                    Genitales_Externos = table.Column<string>(nullable: true),
                    Extremidades_Superiores = table.Column<string>(nullable: true),
                    Extremidades_Inferiores = table.Column<string>(nullable: true),
                    TA = table.Column<string>(nullable: true),
                    FC = table.Column<string>(nullable: true),
                    FR = table.Column<string>(nullable: true),
                    Pulso = table.Column<string>(nullable: true),
                    Temperatura = table.Column<string>(nullable: true),
                    Nota_Ingreso = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    WasDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicalhistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicalhistories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicalhistories_UserId",
                table: "Medicalhistories",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicalhistories");
        }
    }
}
