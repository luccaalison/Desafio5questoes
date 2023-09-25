using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questao5.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
              table: "ContasCorrentes",
              columns: new[] { "IdContaCorrente", "Numero", "Nome", "Ativo" },
              values: new object[] { "FA99D033-7067-ED11-96C6-7C5DFA4A16C9", 456, "Eva Woodward", true });

            migrationBuilder.InsertData(
                table: "ContasCorrentes",
                columns: new[] { "IdContaCorrente", "Numero", "Nome", "Ativo" },
                values: new object[] { "382D323D-7067-ED11-8866-7D5DFA4A16C9", 789, "Tevin Mcconnell", true });

            

            migrationBuilder.InsertData(
                table: "ContasCorrentes",
                columns: new[] { "idcontacorrente", "Numero", "Nome", "Ativo" },
                values: new object[] { "BCDACA4A-7067-ED11-AF81-825DFA4A16C9", 852, "Jarrad Mckee", false });

            migrationBuilder.InsertData(
                table: "ContasCorrentes",
                columns: new[] { "IdContaCorrente", "Numero", "Nome", "Ativo" },
                values: new object[] { "D2E02051-7067-ED11-94C0-835DFA4A16C9", 963, "Elisha Simons", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
