using System;
using System.Collections.Generic;

namespace EMPLOYEES.Dominio.Entidades;

public partial class Usuario
{
    public int IdEmp { get; set; } 

    public string Password { get; set; } = null!;

    public string Correo { get; set; } = null!;
}
