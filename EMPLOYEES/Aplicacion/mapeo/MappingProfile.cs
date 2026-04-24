using AutoMapper;
using EMPLOYEES.Aplicacion.dtos;
using EMPLOYEES.Dominio.Entidades;

namespace EMPLOYEES.Aplicacion.mapeo
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Empresa, EmpresaDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Admin, AdminDto>().ReverseMap();
            
        }
    }

}