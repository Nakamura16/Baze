using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BAZE.Models
{
    public class UsuarioDesafio
    {
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public Desafio Desafio { get; set; }
        public int DesafioId { get; set; }

        [Column("Dt_Nascimento"), Display(Name = "Data de Nascimento"), DataType(DataType.Date)]
        public DateTime DataRegistro { get; set; }
    }
}
