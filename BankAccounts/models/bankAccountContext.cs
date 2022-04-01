using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BankAccounts.models
{
    public partial class BankAccountContext : DbContext
    {
        public BankAccountContext()
        {
        }

        public BankAccountContext(DbContextOptions<BankAccountContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<ContaCorrente> ContaCorrentes { get; set; } = null!;
        public virtual DbSet<ContaPoupanca> ContaPoupancas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;password=1234;database=BankAccount", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<ContaCorrente>(entity =>
            {
                entity.HasKey(e => e.IdContaCorrente)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.IdAccountNavigation)
                    .WithMany(p => p.ContaCorrentes)
                    .HasForeignKey(d => d.IdAccount)
                    .HasConstraintName("conta_corrente_ibfk_1");
            });

            modelBuilder.Entity<ContaPoupanca>(entity =>
            {
                entity.HasKey(e => e.IdContaPoupanca)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.IdAccountNavigation)
                    .WithMany(p => p.ContaPoupancas)
                    .HasForeignKey(d => d.IdAccount)
                    .HasConstraintName("conta_poupanca_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
