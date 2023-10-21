using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class InventarioTallaDto : BaseEntity
    {
        public int IdInventarioFk { get; set; }
        public Inventario Inventario { get; set; }
        public int IdTallaFk { get; set; }
        public Talla Talla { get; set; }
        public int Cantidad { get; set; }
    }
}