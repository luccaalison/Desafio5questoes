using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Dapper.Contrib.Extensions.Table("Movimentos")] // Nome da tabela
public class Movimento
{
    [System.ComponentModel.DataAnnotations.Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string IdMovimento { get; set; }
    public string IdContaCorrente { get; set; }
    [Column("datamovimento")] // Nome da coluna
    [DataType(DataType.Date)]
    public string DataMovimento { get; set; }
    [Column("tipomovimento")] // Nome da coluna
    public char TipoMovimento { get; set; }
    public decimal Valor { get; set; }
}
