using System;
using System.Collections.Generic;
using EMPLOYEES.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EMPLOYEES.Infraestructura.Contexto;

public partial class EmployeesDbContext : DbContext
{
    public EmployeesDbContext()
    {
    }

    public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseNpgsql("Host=localhost;Database=employees;Username=postgres;Password=LOL");
}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => new { e.IdEmp, e.IdEmpresa }).HasName("Admin_pkey");

            entity.ToTable("Admin");

            entity.Property(e => e.IdEmp).HasColumnName("ID_emp");
            entity.Property(e => e.IdEmpresa).HasColumnName("ID_empresa");
            entity.Property(e => e.Nombre)
                .HasColumnType("char")
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.Admins)
                .HasForeignKey(d => d.IdEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ID_emp");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => new { e.IdEmp, e.IdEmpresa }).HasName("Empleado_ID");

            entity.ToTable("Empleado");

            entity.Property(e => e.IdEmp).HasColumnName("ID_emp");
            entity.Property(e => e.IdEmpresa).HasColumnName("ID_empresa");
            entity.Property(e => e.Nombre)
                .HasColumnType("char")
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ID_emp");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("Empresa_pkey");

            entity.ToTable("Empresa");

            entity.Property(e => e.IdEmpresa).HasColumnName("ID_empresa");
            entity.Property(e => e.Factura).HasColumnName("factura");
            entity.Property(e => e.Nombre)
                .HasColumnType("char")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdEmp).HasName("Usuario_pkey");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdEmp).HasColumnName("ID_emp");
            entity.Property(e => e.Correo)
                .HasColumnType("char")
                .HasColumnName("correo");
            entity.Property(e => e.Password)
                .HasColumnType("char")
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

