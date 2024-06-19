using System.ComponentModel.DataAnnotations;
namespace Xtrato.Web.Models;

public class Lancamento
{
    [Key]
    public string Id { get; set; }
    public string Descricao { get; set; }
    [DataType(DataType.Date)]
    public DateTime Data { get; set; }
    public decimal Valor { get; set; }
    public Lancamento()
    {
        Id = Guid.NewGuid().ToString();
    }
}