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

   
  
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
modelBuilder.ApplyConfiguration(new  FluentConfiguracion.Empresa_FluentConfiguration());
modelBuilder.ApplyConfiguration(new  FluentConfiguracion.Empleado_FluentConfiguration());
modelBuilder.ApplyConfiguration(new  FluentConfiguracion.Admin_FluentConfiguration());
modelBuilder.ApplyConfiguration(new  FluentConfiguracion.Usuario_FluentConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
