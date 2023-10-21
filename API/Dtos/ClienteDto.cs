using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class ClienteDto : BaseEntity
    {
        public int DniCliente { get; set; }
        //Orginalmente el campo es IdCliente, se cambia para no generar conflicto con los nombre para llaves foraneas en otras entidades
        public string Nombre { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public int IdMunicipioFk { get; set; }
        public Municipio Municipio { get; set; }
    }
}