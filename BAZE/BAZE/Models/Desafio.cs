using System.ComponentModel.DataAnnotations.Schema;

namespace BAZE.Models
{
    [Table("T_Desafio")]
    public class Desafio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TempoMin { get; set; }
        public string Recompensa { get; set; }
    }
}
