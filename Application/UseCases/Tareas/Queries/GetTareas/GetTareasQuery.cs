using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Tareas.Queries.GetTareas
{
    public class GetTareasQuery() : IRequest<Result<GetTareasQueryDto>>
    {
        public class GetTareasQueryHandler(IRepository<Tarea> repository) : UseCaseHandler, IRequestHandler<GetTareasQuery, Result<GetTareasQueryDto>>
        {
            public async Task<Result<GetTareasQueryDto>> Handle(GetTareasQuery request, CancellationToken cancellationToken)
            {
                var result = await repository.GetAllAsync();

                var tareas = result.Select(x => new GetTareasQueryValueDto
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Estado = x.Estado,
                    FechaCreacion = x.FechaCreacion,
                    FechaFin = x.FechaFin,
                }).ToList();

                var response = new GetTareasQueryDto()
                {
                    Tareas = tareas
                };
                return Succeded(response);
             }
        }
    }
}
