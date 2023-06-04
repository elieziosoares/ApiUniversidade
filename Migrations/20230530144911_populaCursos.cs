using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiUniversidade.Migrations;
/// <inheritdoc />
public partial class populaCursos : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql(@"INSERT INTO CURSOS(Nome,Area,Duracao) 
            VALUES('Tecnologia em Sistemas para Internet','Computação',6)");
        migrationBuilder.Sql(@"INSERT INTO CURSOS(Nome,Area,Duracao) 
            VALUES('Técnico Integrado em Informática','Computação',8)");
        migrationBuilder.Sql(@"INSERT INTO CURSOS(Nome,Area,Duracao) 
            VALUES('Técnico Integrado em Alimentos','Alimentos',8)");    
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELETE FROM CURSOS;");
    }
}
