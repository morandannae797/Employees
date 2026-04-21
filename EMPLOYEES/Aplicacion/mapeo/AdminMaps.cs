using EMPLOYEES.Dominio.Entidades;
using EMPLOYEES.Aplicacion.dtos;

namespace EMPLOYEES.Aplicacion.mapeo
{
    public static class AdminMap {
public static AdminDto ConvertirADtos (Admin admin)
{ return new AdminDto
{
ID_empresa= admin.IdEmpresa,
Nombre = admin.Nombre,
ID_emp = admin.IdEmp,

};
}}


}