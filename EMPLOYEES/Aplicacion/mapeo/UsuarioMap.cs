using EMPLOYEES.Dominio.Entidades;
using EMPLOYEES.Aplicacion.dtos;

namespace EMPLOYEES.Aplicacion.mapeo
{
    public static class UsuarioMap {
public static UsuarioDto ConvertirADtos (Usuario usuario)
{ return new UsuarioDto
{
ID_emp= usuario.IdEmp,
correo = usuario.Correo,

};
}}

}