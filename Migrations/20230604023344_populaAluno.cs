using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiUniversidade.Migrations
{
    /// <inheritdoc />
    public partial class populaAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO public.alunos(nome, datanascimento, cpf, cursoid)
	        VALUES ('Zezinho', '2000-01-01', '123.123.123.12', 1);");
            migrationBuilder.Sql(@"INSERT INTO public.alunos(nome, datanascimento, cpf, cursoid)
	        VALUES ('Mariazinha', '2001-01-01', '321.321.321-32', 1);");
            migrationBuilder.Sql(@"INSERT INTO public.alunos(nome, datanascimento, cpf, cursoid)
	        VALUES ('Juquinha', '2000-02-02', '132.132.132-13', 1);");

            migrationBuilder.Sql(@"INSERT INTO public.alunos(nome, datanascimento, cpf, cursoid)
	        VALUES ('Misael', '1961-11-25', '111.111.111-11', 2);");
            migrationBuilder.Sql(@"INSERT INTO public.alunos(nome, datanascimento, cpf, cursoid)
	        VALUES ('Francisca', '1962-04-06', '222.222.222-22', 2);");

            migrationBuilder.Sql(@"INSERT INTO public.alunos(nome, datanascimento, cpf, cursoid)
	        VALUES ('Jéssica', '2000-03-07', '333.333.333-33', 3);");
            migrationBuilder.Sql(@"INSERT INTO public.alunos(nome, datanascimento, cpf, cursoid)
	        VALUES ('Laura', '2002-02-22', '444.444.444-44', 3);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ALUNOS;");
        }
    }
}
