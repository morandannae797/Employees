using System;
using System.Collections.Generic;

namespace EMPLOYEES.Dominio.Entidades;

public partial class Usuario
{
    public List<int> IdEmp { get; set; } = null!;

    public char Password { get; set; }

    public char Correo { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
