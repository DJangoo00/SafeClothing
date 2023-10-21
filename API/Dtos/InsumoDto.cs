using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class InsumoDto : BaseEntity
    {
        public string Nombre { get; set; }
        public int ValorUnit { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
    }
}