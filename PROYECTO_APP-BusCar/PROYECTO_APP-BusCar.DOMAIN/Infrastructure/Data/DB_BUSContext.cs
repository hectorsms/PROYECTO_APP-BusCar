using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PROYECTO_APP_BusCar.DOMAIN.Core.Entities;

namespace PROYECTO_APP_BusCar.DOMAIN.Infrastructure.Data
{
    public partial class DB_BUSContext : DbContext
    {
        public DB_BUSContext()
        {
        }

        public DB_BUSContext(DbContextOptions<DB_BUSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Documento> Documento { get; set; } = null!;
        public virtual DbSet<Marca> Marca { get; set; } = null!;
        public virtual DbSet<Modelo> Modelo { get; set; } = null!;
        public virtual DbSet<Nivel> Nivel { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-8473IPO8\\CURSOBI;Database=DB_BUS;Integrated Security = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.IdDocumento);

                entity.ToTable("DOCUMENTO");

                entity.Property(e => e.IdDocumento).HasColumnName("id_documento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdMarca);

                entity.ToTable("MARCA");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.HasKey(e => e.IdModelo);

                entity.ToTable("MODELO");

                entity.Property(e => e.IdModelo).HasColumnName("id_modelo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Nivel>(entity =>
            {
                entity.HasKey(e => e.IdNivel);

                entity.ToTable("NIVEL");

                entity.Property(e => e.IdNivel).HasColumnName("id_nivel");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
