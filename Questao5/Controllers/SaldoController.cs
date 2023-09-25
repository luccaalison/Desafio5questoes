using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Linq;

namespace Questao5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaldoController : ControllerBase
    {
        private readonly IDbConnection _dbConnection;

        public SaldoController(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet]
        [Route("consultar/{idContaCorrente}")]
        public IActionResult ConsultarSaldo([FromRoute] string idContaCorrente)
        {
            // Verifique se a conta corrente existe e está ativa no banco de dados
            var contaCorrente = _dbConnection.QueryFirstOrDefault<ContaCorrente>(
                "SELECT * FROM ContasCorrentes WHERE IdContaCorrente = @idContaCorrente",
                new { idContaCorrente });
           
            if (contaCorrente == null)
            {
                return BadRequest("Conta corrente não encontrada");
            }

            if (contaCorrente.Ativo != true)
            {
                return BadRequest("Conta corrente inativa");
            }

            // Consulte os movimentos relacionados a esta conta corrente
            var movimentos = _dbConnection.Query<Movimento>(
                "SELECT * FROM Movimentos WHERE IdContaCorrente = @idContaCorrente",
                new { idContaCorrente });

            // Calcule o saldo somando todos os créditos e subtraindo todos os débitos
            decimal saldo = movimentos.Sum(movimento => movimento.TipoMovimento == 'C' ? movimento.Valor : -movimento.Valor);

            // Retorne os dados da conta corrente e o saldo atual em caso de sucesso
            return Ok(new
            {
                NumeroContaCorrente = contaCorrente.Numero,
                NomeTitular = contaCorrente.Nome,
                DataHoraConsulta = DateTime.Now,
                SaldoAtual = saldo
            });
        }
    }
}
