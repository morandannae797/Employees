using System;
using System.Collections.Generic;

namespace EMPLOYEES.Dominio.Entidades;

public partial class Empresa
{
    public List<int> IdEmpresa { get; set; } = null!;

    public char Nombre { get; set; }

    public bool Factura { get; set; }
}
