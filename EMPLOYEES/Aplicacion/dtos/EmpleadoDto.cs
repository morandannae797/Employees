using System.ComponentModel.DataAnnotations;

public class EmpleadoDto
{
    [Required]
    public int ID_emp {get; set;}

public string Nombre {get; set; }
public int ID_empresa {get; set; }
}