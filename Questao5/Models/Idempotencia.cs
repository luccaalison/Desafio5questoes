using Dapper.Contrib.Extensions;

[Table("idempotencia")] // Nome da tabela
public class Idempotencia
{
    [Key]
    public string ChaveIdempotencia { get; set; }
    public string Requisicao { get; set; }
    public string Resultado { get; set; }
}
