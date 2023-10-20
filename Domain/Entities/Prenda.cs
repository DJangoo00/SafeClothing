namespace Domain.Entities;
public class Prenda : BaseEntity
{
    public int IdePrenda { get; set;}
    //Orginalmente el campo es IdPrenda, se cambia para no generar conflicto con los nombre para llaves foraneas en otras entidades
    public string Nombre { get; set;}
    public int ValorUnitCop { get; set;}
    public int ValorUnitUsd { get; set;}
    public int IdEstadoFk { get; set;}
    public Estado Estado { get; set;}
    public int IdTipoProteccionFK { get; set;}
    public TipoProteccion TipoProteccion { get; set;}
    public int IdGenero { get; set;}
    public Genero Genero { get; set;}
    public ICollection<InsumoPrenda> InsumosPrendas { get; set;}
    public ICollection<Inventario> Inventarios { get; set;}
    public ICollection<DetalleOrden> DetallesOrdenes { get; set;}
}
