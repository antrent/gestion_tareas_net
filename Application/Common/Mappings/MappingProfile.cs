using Application.UseCases.Tareas.Commands.CreateTarea;
using AutoMapper;

namespace Application.Common.Mappings;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        this.CreateMap<CreateTareasCommandModel, CreateTareasCommand>();
    }
}
