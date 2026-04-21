using System.ComponentModel.DataAnnotations;

public class AdminDto
{
    [Required]
public int ID_emp {get; set;}
[Required]public string Nombre {get; set; }
public int ID_empresa {get; set; }
}