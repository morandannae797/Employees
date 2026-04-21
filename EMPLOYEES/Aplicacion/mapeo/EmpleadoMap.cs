using EMPLOYEES.Dominio.Entidades;
using EMPLOYEES.Aplicacion.dtos;
namespace EMPLOYEES.Aplicacion.mapeo
{
public static class EmpleadoMap{
    public static EmpleadoDto ConvertirADtos (Empleado empleado)
{
return new EmpleadoDto{
ID_emp = empleado.IdEmp,
Nombre = empleado.Nombre,
ID_empresa = empleado.IdEmpresa,
};
}
}



}