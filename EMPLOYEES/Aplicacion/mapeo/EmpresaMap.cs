using EMPLOYEES.Dominio.Entidades;
using EMPLOYEES.Aplicacion.dtos;

namespace EMPLOYEES.Aplicacion.mapeo{
public static class EmpresaMap {
public static EmpresaDto ConvertirADtos (Empresa empresa)
{ return new EmpresaDto
{
ID_empresa= empresa.IdEmpresa,
Nombre = empresa.Nombre,
Factura = empresa.Factura,

};
}}}