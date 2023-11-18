using System.ComponentModel.DataAnnotations;

namespace BAZE.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? RegistroGeral { get; set; }
        public string? NumeroPessoaFisica { get; set; }
        public string? Email { get; set; }
        public string? NomeUsuario { get; set; }

        [DataType(DataType.Date), Display(Name = "Data de Criação")]
        public DateTime DataNascimento { get; set; }
        public double PesoKG { get; set; }
        public int AlturaCM { get; set; }
        public Genero Genero { get; set; }
        public string Senha { get; set; }
    }
}

public enum Genero { Masculino , Feminino , Outro}


