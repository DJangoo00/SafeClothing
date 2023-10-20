namespace Domain.Entities;
public class Inventario : BaseEntity
{
    public int CodInv { get; set;}
    public int IdPrendaFk { get; set;}
    public Prenda Prenda { get; set;}
    public int ValorVtaCop { get; set;}
    public int ValorVtaUsd { get; set;}

    public ICollection<InventarioTalla> InventariosTallas{ get; set;}
    public ICollection<DetalleVenta> DetallesVentas{ get; set;}
}