using Application.UseCases.Common.Results;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Core;

namespace gestion_tareas_net.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator? _mediator;
        
        protected IMediator Mediator => this._mediator ??= EngineContext.Current.Resolve<IMediator>();
        
        protected IMapper Mapper => EngineContext.Current.Resolve<Mapper>();

        protected ActionResult FromResult<T>(Result<T> result) => result.ResultType switch
        {
            ResultType.Ok => this.Ok(result),
            ResultType.NotFound => this.NotFound(result),
            ResultType.Created => this.Created(string.Empty,result),
            _ => throw new Exception("Unhandled Result"),
        };
    }
}
