using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gcodb.Migrations
{
    /// <inheritdoc />
    public partial class INS_MAIS_REGISTROS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TABELATESTE (ID, DESCRICAO, DATAHORA) VALUES (4, 'Registro4', NOW())");
            migrationBuilder.Sql("INSERT INTO TABELATESTE (ID, DESCRICAO, DATAHORA) VALUES (5, 'Registro5', NOW())");
            migrationBuilder.Sql("INSERT INTO TABELATESTE (ID, DESCRICAO, DATAHORA) VALUES (6, 'Registro6', NOW())");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TABELATESTE WHERE ID IN (4, 5, 6)");
        }
    }
}
