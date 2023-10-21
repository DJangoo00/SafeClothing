using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class DetalleVentaDto : BaseEntity
    {
        public int IdVentaFk { get; set; }
        public Venta Venta { get; set; }
        public int IdProductoFk { get; set; }
        public Inventario Inventario { get; set; }
        public int IdTallaFk { get; set; }
        public Talla Talla { get; set; }
        public int Cantidad { get; set; }
        public int ValorUnit { get; set; }
    }
}