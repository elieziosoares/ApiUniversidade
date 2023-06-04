using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiUniversidade.Migrations
{
    /// <inheritdoc />
    public partial class populaDisciplina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO disciplinas(nome, cargahoraria, semestre, cursoid)
             values('Algoritmos', 60, 1, 1)");
             migrationBuilder.Sql(@"INSERT INTO disciplinas(nome, cargahoraria, semestre, cursoid)
             values('Programação Orientada a Objetos', 60, 2, 1)");
             migrationBuilder.Sql(@"INSERT INTO disciplinas(nome, cargahoraria, semestre, cursoid)
             values('Programação Orientada a Objetos', 60, 2, 2)");
             migrationBuilder.Sql(@"INSERT INTO disciplinas(nome, cargahoraria, semestre, cursoid)
             values('Algoritmos', 60, 1, 2)");

             migrationBuilder.Sql(@"INSERT INTO disciplinas(nome, cargahoraria, semestre, cursoid)
             values('Lingua Portuguesa', 60, 1, 3)");
             migrationBuilder.Sql(@"INSERT INTO disciplinas(nome, cargahoraria, semestre, cursoid)
             values('Química I', 60, 1, 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM DISCIPLINAS;");
        }
    }
}
