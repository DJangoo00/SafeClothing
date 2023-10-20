namespace Domain.Entities;
public class Empleado : BaseEntity
{
    public int DniEmpelado { get; set; }
    //Orginalmente el campo es IdEmpleado, se cambia para no generar conflicto con los nombre para llaves foraneas en otras entidades
    public string Nombre { get; set; }
    public int IdCargoFk { get; set; }
    public Cargo Cargo { get; set; }
    public DateOnly FechaIngreso { get; set; }
    public int IdMunicipioFk { get; set; }
    public Municipio Municipio { get; set; }
    public ICollection<Venta> Ventas { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
}