using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicalassitent.web.Migrations
{
    public partial class AddDailyEolutionoftheInternalPatientsModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyEvolutionoftheInternalPatients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_internamiento = table.Column<int>(nullable: false),
                    Id_Medico = table.Column<int>(nullable: false),
                    Id_CentroMedico = table.Column<int>(nullable: false),
                    Numero_Record = table.Column<int>(nullable: false),
                    Hora = table.Column<DateTime>(nullable: false),
                    NotadeEvaluacion = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    WasDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyEvolutionoftheInternalPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyEvolutionoftheInternalPatients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyEvolutionoftheInternalPatients_UserId",
                table: "DailyEvolutionoftheInternalPatients",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyEvolutionoftheInternalPatients");
        }
    }
}
