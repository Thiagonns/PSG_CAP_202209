﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Dominio.EF
{
    public partial class ViajeFacilContext : DbContext
    {
        public DbSet<Pais> Paises { get; set; } = null!;
        public DbSet<Regiao> Regioes { get; set; } = null!;
        public DbSet<Estado> Estados { get; set; } = null!;
        public DbSet<Cidade> Cidades { get; set; } = null!;
        public DbSet<Endereco> Enderecos { get; set; } = null!;
        public DbSet<Instituicao> Instituicoes { get; set; } = null!;
        public DbSet<Evento> Eventos { get; set; } = null!;
        public DbSet<Rota> Rotas { get; set; } = null!;
        public DbSet<PontoParada> PontoParadas { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<ParticipanteEvento> ParticipanteEventos { get; set; } = null!;
        public DbSet<TipoUsuario> TipoUsuarios { get; set; } = null!;



        protected ViajeFacilContext() : base()
        {
        }
        public ViajeFacilContext(DbContextOptions<ViajeFacilContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                 optionsBuilder.UseSqlServer("Data Source=(local); Initial Catalog=SA;User=sa;Password=Senha123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* 
            
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
           
            */

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
