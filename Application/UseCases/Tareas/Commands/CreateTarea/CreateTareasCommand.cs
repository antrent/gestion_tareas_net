using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Tareas.Commands.CreateTarea
{
    public class CreateTareasCommand : CreateTareasCommandModel, IRequest<Result<CreateTareasCommandDto>>
    {
        public class CreateTareasCommandHandler(
            IRepository<Tarea> repository) : UseCaseHandler, IRequestHandler<CreateTareasCommand, Result<CreateTareasCommandDto>>
        {
            public async Task<Result<CreateTareasCommandDto>> Handle(CreateTareasCommand request, CancellationToken cancellationToken)
            {

               var tarea = new Tarea()
                {
                   Id = request.Id,
                   Nombre = request.Nombre,
                   Estado = request.Estado,
                   FechaCreacion = request.FechaCreacion,
                   FechaFin = request.FechaFin,
                };

                await repository.AddAsync(tarea);

                var response = new CreateTareasCommandDto()
                {
                    Success = true
                };
                return Succeded(response);
             }
        }
    }
}
