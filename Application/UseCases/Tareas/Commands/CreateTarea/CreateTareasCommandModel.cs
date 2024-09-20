namespace Application.UseCases.Tareas.Commands.CreateTarea
{
    public class CreateTareasCommandModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
