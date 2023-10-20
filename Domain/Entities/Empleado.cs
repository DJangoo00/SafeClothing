using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Empleado : BaseEntity
{
    public int DniEmpelado { get; set; }
    //Orginalmente el campo es IdEmpleado, se cambia para no generar conflicto con los nombre para llaves foraneas en otras entidades
    public string Nombre { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public DateOnly FechaRegistro { get; set; }
    public int IdMunicipioFk { get; set; }
    public Municipio Municipio { get; set; }
}