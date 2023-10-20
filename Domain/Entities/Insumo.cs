namespace Domain.Entities;
public class Insumo : BaseEntity
{
    public string Nombre { get; set; }
    public int ValorUnit { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
    public ICollection<InsumoProveedor> InsumosProveedores { get; set; }
    public ICollection<Proveedor> Proveedores { get; set; }
    public ICollection<InsumoPrenda> InsumosPrendas { get; set; }    
}
