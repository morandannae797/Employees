using System.ComponentModel.DataAnnotations;
namespace EMPLOYEES.Aplicacion.dtos{
public class UsuarioDto
{  [Required]

    public int ID_emp { get; set; }
      public string correo { get; set; }
    

}}