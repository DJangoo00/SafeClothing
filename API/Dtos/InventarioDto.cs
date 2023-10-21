using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class InventarioDto : BaseEntity
    {
        public int CodInv { get; set; }
        public int IdPrendaFk { get; set; }
        public Prenda Prenda { get; set; }
        public int ValorVtaCop { get; set; }
        public int ValorVtaUsd { get; set; }
    }
}