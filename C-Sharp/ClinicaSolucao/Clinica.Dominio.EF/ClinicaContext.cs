﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Dominio.EF
{
    public partial class ClinicaContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; } = null!;
        public DbSet<Agenda> Agendas { get; set; } = null!;
        public DbSet<Consulta> Consultas { get; set; } = null!;
        public DbSet<Profissao> Profissoes { get; set; } = null!;
        public DbSet<Servico> Servicos { get; set; } = null!;
        public DbSet<TipoServico> TiposServicos { get; set; } = null!;



        protected ClinicaContext() : base()
        {
        }
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // optionsBuilder.UseSqlServer("Data Source=psgs0071.psg.local; Initial Catalog=Academia;User=academia;Password=@cadem1@555;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Agenda>(entity =>
            {
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
