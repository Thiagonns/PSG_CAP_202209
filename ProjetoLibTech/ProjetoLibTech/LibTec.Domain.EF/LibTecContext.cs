using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibTec.Domain.EF
{
    public partial class LibTecContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; } = null!;
        public DbSet<AutorPorItem> AutorPorItens { get; set; } = null!;
        public DbSet<Emprestimo> Emprestimos { get; set; } = null!;
        public DbSet<Item> Itens { get; set; } = null!;
        public DbSet<Reserva> Reservas { get; set; } = null!;
        public DbSet<TipoItem> TipoItens { get; set; } = null!;
        public DbSet<TipoStatusEmprestimo> TipoStatusEmprestimos { get; set; } = null!;
        public DbSet<TipoStatusReserva> TipoStatusReservas { get; set; } = null!;
        public DbSet<TipoUsuario> TipoUsuario { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;

        protected LibTecContext() : base()
        {
        }
        public LibTecContext(DbContextOptions<LibTecContext> options) : base(options)
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
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<AutorPorItem>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<Emprestimo>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            }); modelBuilder.Entity<TipoItem>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<TipoStatusEmprestimo>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<TipoStatusReserva>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}