using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Avaliar.Domain.EF
{
    public partial class AvaliarContext : DbContext
    {
        public DbSet<InstituicaoBancaria> InstituicoesBancarias { get; set; } = null!;
        public DbSet<Correntista> Correntistas { get; set; } = null!;
        protected AvaliarContext()
        {
        }

        public AvaliarContext(DbContextOptions<AvaliarContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstituicaoBancaria>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Correntista>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
