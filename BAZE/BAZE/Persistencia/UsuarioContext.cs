using BAZE.Models;
using Microsoft.EntityFrameworkCore;

namespace BAZE.Persistencia
{
    //Classe que gerencia as entidades
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public UsuarioContext(DbContextOptions op) : base(op) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //Configurar a PK da tabela associativa
        //    modelBuilder.Entity<PacienteMedicamento>()
        //        .HasKey(p => new { p.PacienteId, p.MedicamentoId });

        //    //Configurar a relação da tabela associativa com o Paciente
        //    modelBuilder.Entity<PacienteMedicamento>()
        //        .HasOne(p => p.Paciente)
        //        .WithMany(p => p.PacientesMedicamentos)
        //        .HasForeignKey(p => p.PacienteId);

        //    //Configurar a relação da tabela associativa com o Medicamento
        //    modelBuilder.Entity<PacienteMedicamento>()
        //        .HasOne(p => p.Medicamento)
        //        .WithMany(p => p.PacientesMedicamentos)
        //        .HasForeignKey(p => p.MedicamentoId);

        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
