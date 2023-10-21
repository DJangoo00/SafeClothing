using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class CargoDto : BaseEntity
    {
        public string Descripcion { get; set; }
        public int SueldoBase { get; set; }
    }
}