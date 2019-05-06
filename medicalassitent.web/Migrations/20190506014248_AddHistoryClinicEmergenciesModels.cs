using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicalassitent.web.Migrations
{
    public partial class AddHistoryClinicEmergenciesModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoryClinicEmergencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    No_Registro = table.Column<int>(nullable: false),
                    Id_Paciente = table.Column<int>(nullable: false),
                    Referido = table.Column<string>(nullable: true),
                    Mo_Emergencia = table.Column<string>(nullable: true),
                    Ant_ClinicosQ = table.Column<string>(nullable: true),
                    Me_UsadosRec = table.Column<string>(nullable: true),
                    Alergias = table.Column<string>(nullable: true),
                    TA = table.Column<string>(nullable: true),
                    FC = table.Column<string>(nullable: true),
                    FR = table.Column<string>(nullable: true),
                    Pulso = table.Column<string>(nullable: true),
                    Temp = table.Column<string>(nullable: true),
                    H_PositivosExF = table.Column<string>(nullable: true),
                    Clinica = table.Column<bool>(nullable: false),
                    Acc_Transito = table.Column<bool>(nullable: false),
                    Acc_Laboral = table.Column<bool>(nullable: false),
                    He_Bala = table.Column<bool>(nullable: false),
                    Politraumatismo = table.Column<bool>(nullable: false),
                    Otros = table.Column<string>(nullable: true),
                    Hemograma = table.Column<string>(nullable: true),
                    Orina = table.Column<string>(nullable: true),
                    Glicemia = table.Column<string>(nullable: true),
                    Prueba_Embarazo = table.Column<string>(nullable: true),
                    Otros2 = table.Column<string>(nullable: true),
                    Radiografias = table.Column<string>(nullable: true),
                    EKG = table.Column<string>(nullable: true),
                    Otros3 = table.Column<string>(nullable: true),
                    Diagnosticos = table.Column<string>(nullable: true),
                    Sutura = table.Column<bool>(nullable: false),
                    Inmovilizacion = table.Column<bool>(nullable: false),
                    Reanimacion = table.Column<bool>(nullable: false),
                    Nebulizacion = table.Column<bool>(nullable: false),
                    Otros4 = table.Column<string>(nullable: true),
                    Alta = table.Column<bool>(nullable: false),
                    Ingreso_Hosp = table.Column<bool>(nullable: false),
                    Ref_Consulta = table.Column<bool>(nullable: false),
                    Ref_Centro = table.Column<bool>(nullable: false),
                    Otros5 = table.Column<bool>(nullable: false),
                    Id_Medico = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    WasDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryClinicEmergencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryClinicEmergencies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoryClinicEmergencies_UserId",
                table: "HistoryClinicEmergencies",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryClinicEmergencies");
        }
    }
}
