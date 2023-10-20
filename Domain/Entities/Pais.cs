namespace Domain.Entities;
    public class Pais : BaseEntity
{
    public string Nombre { get; set; }
    ICollection<Departamento> Departamentos { get; set; }
}
