using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Dapper.Contrib.Extensions.Table("contacorrente")] // Nome da tabela
public class ContaCorrente
{
    [System.ComponentModel.DataAnnotations.Key]
    public string IdContaCorrente { get; set; }
    public int Numero { get; set; }
    public string Nome { get; set; }
    public bool Ativo { get; set; }
}
