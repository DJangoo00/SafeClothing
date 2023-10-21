using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class ProveedorDto : BaseEntity
    {
        public int Nit { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public int IdMunicipioFk { get; set; }
        public Municipio Municipio { get; set; }
    }
}