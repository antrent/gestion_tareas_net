using Application.UseCases.Tareas.Commands.CreateTarea;
using Application.UseCases.Tareas.Queries.GetTareas;
using Microsoft.AspNetCore.Mvc;


namespace gestion_tareas_net.Controllers
{
    public class TareaController : BaseController
    {
        [HttpGet]
        [Route("GetAllTareas")]
        public async Task<IActionResult> GetAllTareas() 
        { 
            var query = new GetTareasQuery();
            var result = await this.Mediator.Send(query);
            return this.FromResult(result);
        }

        [HttpPost]
        [Route("CrearTarea")]
        public async Task<IActionResult> CrearTarea(CreateTareasCommandModel model)
        {
            try
            {
                var command = this.Mapper.Map<CreateTareasCommand>(model);
                var result = await this.Mediator.Send(command);
                return this.FromResult(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            } 
            
        }

    }
}
