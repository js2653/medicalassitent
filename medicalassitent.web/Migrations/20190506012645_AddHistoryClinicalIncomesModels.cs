using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicalassitent.web.Migrations
{
    public partial class AddHistoryClinicalIncomesModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoryClinicalIncomes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_Paciente = table.Column<int>(nullable: false),
                    MotivodeConsulta = table.Column<string>(maxLength: 300, nullable: false),
                    HistoriadelaEnfermedadACtual = table.Column<string>(maxLength: 300, nullable: false),
                    Niñes = table.Column<string>(nullable: true),
                    adolecencia = table.Column<string>(nullable: true),
                    Adulta = table.Column<string>(nullable: true),
                    AntecedentesAlergicos = table.Column<string>(nullable: true),
                    AntecedentesTransfuciones = table.Column<string>(nullable: true),
                    AntecedentesQuirurgicas = table.Column<string>(nullable: true),
                    AntecedentesTraumaticas = table.Column<string>(nullable: true),
                    AntecedentesHospitalarios = table.Column<string>(nullable: true),
                    HabitosToxicos = table.Column<string>(nullable: true),
                    Habitad = table.Column<string>(maxLength: 30, nullable: false),
                    PatronAlimenticio = table.Column<string>(maxLength: 30, nullable: false),
                    Padre = table.Column<string>(nullable: true),
                    Madre = table.Column<string>(nullable: true),
                    Hermanos = table.Column<string>(nullable: true),
                    Hijos = table.Column<string>(nullable: true),
                    Conyugue = table.Column<string>(nullable: true),
                    Otro = table.Column<string>(nullable: true),
                    Telarquia = table.Column<string>(nullable: true),
                    Pubarquia = table.Column<string>(nullable: true),
                    Maenarquia = table.Column<string>(nullable: true),
                    NodeConyugues = table.Column<string>(nullable: true),
                    UltimoPapanicolau = table.Column<string>(nullable: true),
                    Fum = table.Column<string>(nullable: true),
                    PatronMenstrual = table.Column<string>(nullable: true),
                    Piel = table.Column<string>(nullable: false),
                    Cabeza = table.Column<string>(nullable: false),
                    Cuello = table.Column<string>(nullable: false),
                    Mamas = table.Column<string>(nullable: false),
                    CardioPulmonar = table.Column<string>(nullable: false),
                    GastroINtestinal = table.Column<string>(nullable: false),
                    GenitoUrinario = table.Column<string>(nullable: false),
                    MusculoEsqueletico = table.Column<string>(nullable: false),
                    Neurologico = table.Column<string>(nullable: false),
                    Psiquiatrico = table.Column<string>(nullable: false),
                    EndocrinoMetabolico = table.Column<string>(nullable: false),
                    Hematologico = table.Column<string>(nullable: false),
                    SV = table.Column<string>(nullable: false),
                    TA = table.Column<string>(nullable: false),
                    FC = table.Column<string>(nullable: false),
                    FR = table.Column<string>(nullable: false),
                    Temperatura = table.Column<string>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    cabeza2 = table.Column<string>(nullable: false),
                    cuello2 = table.Column<string>(nullable: false),
                    Torax = table.Column<string>(nullable: false),
                    Corazon = table.Column<string>(nullable: false),
                    Pulmones = table.Column<string>(nullable: false),
                    Abdomen = table.Column<string>(nullable: false),
                    GenitalesExternos = table.Column<string>(nullable: false),
                    TactoVaginal = table.Column<string>(nullable: false),
                    TactoRectal = table.Column<string>(nullable: false),
                    ExtremidadesInferiores = table.Column<string>(nullable: false),
                    ImpresionDiagnostica = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    WasDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryClinicalIncomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryClinicalIncomes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoryClinicalIncomes_UserId",
                table: "HistoryClinicalIncomes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryClinicalIncomes");
        }
    }
}
