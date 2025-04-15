using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIEscola.Migrations
{
    /// <inheritdoc />
    public partial class GestaoMatricula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Matricula_AlunoId",
                table: "Matricula",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_TurmaId",
                table: "Matricula",
                column: "TurmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Alunos_AlunoId",
                table: "Matricula",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Turmas_TurmaId",
                table: "Matricula",
                column: "TurmaId",
                principalTable: "Turmas",
                principalColumn: "TurmaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Alunos_AlunoId",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Turmas_TurmaId",
                table: "Matricula");

            migrationBuilder.DropIndex(
                name: "IX_Matricula_AlunoId",
                table: "Matricula");

            migrationBuilder.DropIndex(
                name: "IX_Matricula_TurmaId",
                table: "Matricula");
        }
    }
}
