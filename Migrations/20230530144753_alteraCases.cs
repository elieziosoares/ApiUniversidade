using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiUniversidade.Migrations
{
    /// <inheritdoc />
    public partial class alteraCases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Cursos_CursoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Cursos_CursoId",
                table: "Disciplinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Disciplinas",
                table: "Disciplinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Disciplinas",
                newName: "disciplinas");

            migrationBuilder.RenameTable(
                name: "Cursos",
                newName: "cursos");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "alunos");

            migrationBuilder.RenameColumn(
                name: "Semestre",
                table: "disciplinas",
                newName: "semestre");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "disciplinas",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "disciplinas",
                newName: "cursoid");

            migrationBuilder.RenameColumn(
                name: "CargaHoraria",
                table: "disciplinas",
                newName: "cargahoraria");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "disciplinas",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Disciplinas_CursoId",
                table: "disciplinas",
                newName: "IX_disciplinas_cursoid");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "cursos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Duracao",
                table: "cursos",
                newName: "duracao");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "cursos",
                newName: "area");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "cursos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "alunos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "alunos",
                newName: "datanascimento");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "alunos",
                newName: "cursoid");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "alunos",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "alunos",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_CursoId",
                table: "alunos",
                newName: "IX_alunos_cursoid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_disciplinas",
                table: "disciplinas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cursos",
                table: "cursos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_alunos",
                table: "alunos",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_alunos_cursos_cursoid",
                table: "alunos",
                column: "cursoid",
                principalTable: "cursos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_disciplinas_cursos_cursoid",
                table: "disciplinas",
                column: "cursoid",
                principalTable: "cursos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alunos_cursos_cursoid",
                table: "alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_disciplinas_cursos_cursoid",
                table: "disciplinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_disciplinas",
                table: "disciplinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cursos",
                table: "cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_alunos",
                table: "alunos");

            migrationBuilder.RenameTable(
                name: "disciplinas",
                newName: "Disciplinas");

            migrationBuilder.RenameTable(
                name: "cursos",
                newName: "Cursos");

            migrationBuilder.RenameTable(
                name: "alunos",
                newName: "Alunos");

            migrationBuilder.RenameColumn(
                name: "semestre",
                table: "Disciplinas",
                newName: "Semestre");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Disciplinas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "cursoid",
                table: "Disciplinas",
                newName: "CursoId");

            migrationBuilder.RenameColumn(
                name: "cargahoraria",
                table: "Disciplinas",
                newName: "CargaHoraria");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Disciplinas",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_disciplinas_cursoid",
                table: "Disciplinas",
                newName: "IX_Disciplinas_CursoId");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cursos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "duracao",
                table: "Cursos",
                newName: "Duracao");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "Cursos",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cursos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Alunos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "datanascimento",
                table: "Alunos",
                newName: "DataNascimento");

            migrationBuilder.RenameColumn(
                name: "cursoid",
                table: "Alunos",
                newName: "CursoId");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Alunos",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Alunos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_alunos_cursoid",
                table: "Alunos",
                newName: "IX_Alunos_CursoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Disciplinas",
                table: "Disciplinas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Cursos_CursoId",
                table: "Alunos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Cursos_CursoId",
                table: "Disciplinas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
