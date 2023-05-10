using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GymDBData.Entidades;

public partial class GymDbContext : DbContext
{
    public GymDbContext()
    {
    }

    public GymDbContext(DbContextOptions<GymDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asistencia> Asistencias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<MediosDePago> MediosDePagos { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<RedesSociale> RedesSociales { get; set; }

    public virtual DbSet<UsuarioRedCliente> UsuarioRedClientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer(CConfig.ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asistencia>(entity =>
        {
            entity.Property(e => e.Fecha).HasColumnType("date");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Asistencia)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Asistencias_Clientes");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaInscripcion).HasColumnType("date");
            entity.Property(e => e.FechaNacimiento).HasColumnType("date");
            entity.Property(e => e.Mail)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RutaFoto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MediosDePago>(entity =>
        {
            entity.ToTable("MediosDePago");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.Property(e => e.Fecha).HasColumnType("date");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_Pagos_Clientes");

            entity.HasOne(d => d.IdMedioDePagoNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdMedioDePago)
                .HasConstraintName("FK_Pagos_MediosDePago");
        });

        modelBuilder.Entity<RedesSociale>(entity =>
        {
            entity.Property(e => e.NombreRed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsuarioRedCliente>(entity =>
        {
            entity.HasKey(e => new { e.IdCliente, e.IdRed }).HasName("PK_ClientesRedes");

            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.UsuarioRedClientes)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientesRedes_Clientes");

            entity.HasOne(d => d.IdRedNavigation).WithMany(p => p.UsuarioRedClientes)
                .HasForeignKey(d => d.IdRed)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientesRedes_RedesSociales");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
