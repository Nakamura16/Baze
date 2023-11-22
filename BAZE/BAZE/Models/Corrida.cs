using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAZE.Models
{
    [Table("T_Corrida")]
    public class Corrida
    {
        [Column("Id"), HiddenInput, Key]
        public int Id { get; set; }
        public int Quilometros { get; set; }
        public int TempoMin { get; set; }
    }
}
