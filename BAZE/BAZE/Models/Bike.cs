using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAZE.Models
{
    //[Table("T_Bike")]
    public class Bike
    {
        //[Column("Id"), HiddenInput, Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Aro { get; set; }
        public int NrQuadro { get; set; }
        public double Peso { get; set; }
        public string Cor { get; set; }
        public Tipo tipo { get; set; }
        public int QtdMarchas { get; set; }

        //relacionamento bidirecional
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }

    public enum Tipo { Eletrica, Mountain, speed }
}
