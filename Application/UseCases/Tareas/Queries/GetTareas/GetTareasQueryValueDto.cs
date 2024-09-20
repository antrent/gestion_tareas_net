namespace Application.UseCases.Tareas.Queries.GetTareas
{
    public class GetTareasQueryValueDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
