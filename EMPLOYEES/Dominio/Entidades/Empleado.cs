using System;
using System.Collections.Generic;

namespace EMPLOYEES.Dominio.Entidades;

public partial class Empleado
{
    public int IdEmp { get; set; } 
    public string Nombre { get; set; } = null!;

    public int IdEmpresa { get; set; } 

    public virtual Usuario IdEmpNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
