﻿// <auto-generated />
using System;
using BAZE.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BAZE.Migrations
{
    [DbContext(typeof(HospitalContext))]
    partial class HospitalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BAZE.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnderecoId"));

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Tbl_Endereco");
                });

            modelBuilder.Entity("BAZE.Models.Exame", b =>
                {
                    b.Property<int>("ExameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExameId"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("Preparo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExameId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Tbl_Exame");
                });

            modelBuilder.Entity("BAZE.Models.Medicamento", b =>
                {
                    b.Property<int>("MedicamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicamentoId"));

                    b.Property<string>("Laboratorio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime2");

                    b.HasKey("MedicamentoId");

                    b.ToTable("Tbl_Medicamento");
                });

            modelBuilder.Entity("BAZE.Models.Medico", b =>
                {
                    b.Property<int>("MedicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicoId"));

                    b.Property<int>("Crm")
                        .HasColumnType("int");

                    b.Property<int>("Especialidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MedicoId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("BAZE.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacienteId"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("Dt_Nascimento");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("ModalidadeAtendimento")
                        .HasColumnType("int")
                        .HasColumnName("Ds_Modalidade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("PacienteId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Tbl_Paciente");
                });

            modelBuilder.Entity("BAZE.Models.PacienteMedicamento", b =>
                {
                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("MedicamentoId")
                        .HasColumnType("int");

                    b.HasKey("PacienteId", "MedicamentoId");

                    b.HasIndex("MedicamentoId");

                    b.ToTable("PacientesMedicamentos");
                });

            modelBuilder.Entity("BAZE.Models.Exame", b =>
                {
                    b.HasOne("BAZE.Models.Paciente", "Paciente")
                        .WithMany("Exames")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("BAZE.Models.Paciente", b =>
                {
                    b.HasOne("BAZE.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("BAZE.Models.PacienteMedicamento", b =>
                {
                    b.HasOne("BAZE.Models.Medicamento", "Medicamento")
                        .WithMany("PacientesMedicamentos")
                        .HasForeignKey("MedicamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BAZE.Models.Paciente", "Paciente")
                        .WithMany("PacientesMedicamentos")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicamento");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("BAZE.Models.Medicamento", b =>
                {
                    b.Navigation("PacientesMedicamentos");
                });

            modelBuilder.Entity("BAZE.Models.Paciente", b =>
                {
                    b.Navigation("Exames");

                    b.Navigation("PacientesMedicamentos");
                });
#pragma warning restore 612, 618
        }
    }
}