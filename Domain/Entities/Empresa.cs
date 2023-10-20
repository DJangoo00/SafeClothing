namespace Domain.Entities;
public class Empresa : BaseEntity
{
    public int Nit { get; set; }
    public string RazonSocial { get; set; }
    public string RepresetanteLegal { get; set; }
    public DateOnly FechaCreacion { get; set; }
    public int IdMunicipioFk { get; set; }
    public Municipio Municipio { get; set; }
}