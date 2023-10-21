using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class InsumoPrendaDto : BaseEntity
    {
        public int IdInsumoFk { get; set; }
        public Insumo Insumo { get; set; }
        public int IdProveedorFk { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}