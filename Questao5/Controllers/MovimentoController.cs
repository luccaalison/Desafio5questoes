using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using Dapper.Contrib.Extensions; // Certifique-se de que esta diretiva está presente.

namespace Questao5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentoController : ControllerBase
    {
        private readonly IDbConnection _dbConnection;

        public MovimentoController(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpPost]
        [Route("movimentar")]
        public IActionResult MovimentarContaCorrente(Movimento movimentos)
        {
            try
            {
                // Verificar se a conta corrente existe e está ativa no banco de dados
                var contaCorrente = _dbConnection.QueryFirstOrDefault<ContaCorrente>(
                    "SELECT * FROM ContasCorrentes WHERE IdContaCorrente = @IdContaCorrente",
                    new { IdContaCorrente = movimentos.IdContaCorrente });

                movimentos.DataMovimento = DateTime.Now.ToString();

                if (contaCorrente == null)
                {
                    return BadRequest("Conta corrente não encontrada");
                }

                if (contaCorrente.Ativo != true)
                {
                    return BadRequest("Conta corrente inativa");
                }

                // Verificar se o tipo de movimento é válido (Crédito ou Débito)
                if (movimentos.TipoMovimento != 'C' && movimentos.TipoMovimento != 'D')
                {
                    return BadRequest("Tipo de movimento inválido");
                }

                // Exemplo de validação simples (você deve adicionar todas as validações necessárias)
                if (movimentos.Valor <= 0)
                {
                    return BadRequest("Valor inválido");
                }

                // Exemplo de inserção de movimento no banco de dados (você deve ajustar isso)
                _dbConnection.Insert(movimentos);

                // Retorne o HTTP 200 e o ID do movimento gerado em caso de sucesso
                return Ok(new { IdMovimento = movimentos.IdMovimento });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
