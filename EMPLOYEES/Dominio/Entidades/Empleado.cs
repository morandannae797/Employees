using System;
using System.Collections.Generic;

namespace EMPLOYEES.Dominio.Entidades;

public partial class Empleado
{
    public List<int> IdEmp { get; set; } = null!;

    public char Nombre { get; set; }

    public int IdEmpresa { get; set; }

    public virtual Usuario IdEmpNavigation { get; set; } = null!;
}
