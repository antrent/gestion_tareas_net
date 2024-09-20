namespace Domain.Entities;
public class Tarea : BaseEntity
{
    public required string Nombre { get; set; }
    public string Estado { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime? FechaFin { get; set; }

    public Tarea() { }
}