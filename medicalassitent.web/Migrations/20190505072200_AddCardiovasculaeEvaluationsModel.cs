using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicalassitent.web.Migrations
{
    public partial class AddCardiovasculaeEvaluationsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardiovascularEvaluations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_CentroMedico = table.Column<int>(nullable: false),
                    Sala = table.Column<string>(nullable: false),
                    Id_Medico = table.Column<int>(nullable: false),
                    Id_Paciente = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Diagnostico = table.Column<string>(nullable: false),
                    ProcQ_Realizar = table.Column<string>(nullable: false),
                    Alergico = table.Column<string>(nullable: false),
                    H_Toxicos = table.Column<string>(nullable: false),
                    H_CardioVascular = table.Column<string>(nullable: false),
                    SCardio_Actuales = table.Column<string>(maxLength: 30, nullable: false),
                    Sonografia = table.Column<string>(nullable: false),
                    TA = table.Column<string>(nullable: true),
                    FC = table.Column<string>(nullable: true),
                    FR = table.Column<string>(nullable: true),
                    FP = table.Column<string>(nullable: true),
                    Po2 = table.Column<string>(nullable: true),
                    YVY = table.Column<bool>(nullable: false),
                    FPericardio = table.Column<bool>(nullable: false),
                    Roncus = table.Column<bool>(nullable: false),
                    Crepitantes = table.Column<bool>(nullable: false),
                    Ictericia = table.Column<bool>(nullable: false),
                    Hepatomegalia = table.Column<bool>(nullable: false),
                    Esplegnoniegalia = table.Column<bool>(nullable: false),
                    Ascitis = table.Column<bool>(nullable: false),
                    Laboratorio = table.Column<string>(nullable: true),
                    Rad_Torax = table.Column<string>(nullable: true),
                    Electrocardiograma = table.Column<string>(nullable: true),
                    PCVascular_Dest = table.Column<string>(nullable: true),
                    Ot_Patologias = table.Column<string>(nullable: true),
                    Goodman = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    WasDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardiovascularEvaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardiovascularEvaluations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardiovascularEvaluations_UserId",
                table: "CardiovascularEvaluations",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardiovascularEvaluations");
        }
    }
}
