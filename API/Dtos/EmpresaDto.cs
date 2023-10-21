using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class EmpresaDto : BaseEntity
    {
        public int Nit { get; set; }
        public string RazonSocial { get; set; }
        public string RepresetanteLegal { get; set; }
        public DateOnly FechaCreacion { get; set; }
        public int IdMunicipioFk { get; set; }
        public Municipio Municipio { get; set; }
    }
}