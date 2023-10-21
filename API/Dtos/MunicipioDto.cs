using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class MunicipioDto : BaseEntity
    {
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public Departamento Departamento { get; set; }
    }
}