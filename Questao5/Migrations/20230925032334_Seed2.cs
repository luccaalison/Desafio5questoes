using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questao5.Migrations
{
    /// <inheritdoc />
    public partial class Seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ContasCorrentes",
                columns: new[] { "IdContaCorrente", "Numero", "Nome", "Ativo" },
                values: new object[] { "F475F943-7067-ED11-A06B-7E5DFA4A16C9", 741, "Ameena Lynn", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
