
using EMPLOYEES.Aplicacion.servicio.IServicios;
using EMPLOYEES.Dominio.Entidades;
using EMPLOYEES.Aplicacion.servicio;
using EMPLOYEES.Infraestructura.Repositorio;
using EMPLOYEES.Dominio.interfaces;
using AutoMapper;


public interface IEmpleadoMapping : IReadServiceAsync<Empleado, EmpleadoDto> 
{ 
    
}

public class EmpleadoMapping : ReadServiceAsync<Empleado, EmpleadoDto>, IEmpleadoMapping
{
    public EmpleadoMapping(IUnitOfWork unitOfWork , IMapper mapper) 
        : base(unitOfWork, mapper) 
    {
    }
} 
