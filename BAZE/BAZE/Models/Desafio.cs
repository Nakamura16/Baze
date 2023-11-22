using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAZE.Models
{
    [Table("T_Desafio")]
    public class Desafio
    {
        [Column("Id"), HiddenInput, Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TempoMin { get; set; }
        public string Recompensa { get; set; }
    }
}
