using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAZE.Models
{
    //[Table("T_Usuario")]
    public class Usuario
    {
        [Column("Id"), HiddenInput, Key]
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        public string? RegistroGeral { get; set; }
        public string? NumeroPessoaFisica { get; set; }
        public string? Email { get; set; }
        public string? NomeUsuario { get; set; }

        //[Column("Dt_Nascimento"), Display(Name = "Data de Nascimento"),DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public double PesoKG { get; set; }
        public int AlturaCM { get; set; }
        public Genero Genero { get; set; }
        public string Senha { get; set; }
        
        //relacionamentos
        public IList<Telefone>? Telefones { get; set; }
        public IList<Bike>? Bikes { get; set; }
        public IList<Endereco>? Enderecos { get; set; }
        public IList<Desafio>? Desafios { get; set; }
        public IList<Corrida>? Corridas { get; set; }
    }
}

public enum Genero { Masculino , Feminino , Outro}


