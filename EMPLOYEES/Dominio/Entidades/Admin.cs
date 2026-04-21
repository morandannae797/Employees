using System;
using System.Collections.Generic;

namespace EMPLOYEES.Dominio.Entidades;

public partial class Admin
{
    public List<int> IdEmp { get; set; } = null!;

    public char Nombre { get; set; }

    public List<int> IdEmpresa { get; set; } = null!;

    public virtual Usuario IdEmpNavigation { get; set; } = null!;
}
