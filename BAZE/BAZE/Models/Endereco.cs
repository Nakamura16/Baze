﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAZE.Models
{
    //[Table("T_Endereco")]
    public class Endereco
    {
        //[Column("Id"), HiddenInput, Key]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }
        public string complemento { get; set; }

        //Relacionamentos
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
