using System.ComponentModel.DataAnnotations.Schema;

namespace BAZE.Models
{
    [Table("T_Corrida")]
    public class Corrida
    {
        public int Id { get; set; }
        public int Quilometros { get; set; }
        public int TempoMin { get; set; }
    }
}
