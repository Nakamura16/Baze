using BAZE.Models;
using Microsoft.EntityFrameworkCore;

namespace BAZE.Persistencia
{
    //Classe que gerencia as entidades
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Corrida> Corridas { get; set; }
        public DbSet<Desafio> Desafios { get; set; }
        public DbSet<Bike> Bikes { get; set; }

        public UsuarioContext(DbContextOptions op) : base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar a PK da tabela associativa
            modelBuilder.Entity<Usuario>()
                .HasKey(u => new { u.Id});

            //Configurar a relação da tabela associativa com o Paciente
            modelBuilder.Entity<Telefone>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Bike>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<Endereco>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Corrida>()
                .HasKey(c => c.Id);

            //    //Configurar a relação da tabela associativa com o Medicamento
            //    modelBuilder.Entity<PacienteMedicamento>()
            //        .HasOne(p => p.Medicamento)
            //        .WithMany(p => p.PacientesMedicamentos)
            //        .HasForeignKey(p => p.MedicamentoId);

            //    base.OnModelCreating(modelBuilder);
        }

        }
}
