using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAZE.Models
{
    //[Table("T_Usuario_Telefone")]
    public class Telefone
    {
        //[Column("Id"), HiddenInput, Key]
        public int Id { get; set; }
        public string Numero { get; set; }
        public int DDD { get; set; }
        public int DDI { get; set; }

        //Relacionamento bidirecional
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
