namespace Domain.Entities;
public class Medicamento : BaseEntity
{
    public string Nombre { get; set; }
    public int CantidadDisponible { get; set; }
    public int Precio { get; set; }
    public int IdLaboratorioFk { get; set; }
    public ICollection<MedicamentoProveedor> MedicamentosProveedores { get; set; }
    public ICollection<Proveedor> Proveedores { get; set; }
}
