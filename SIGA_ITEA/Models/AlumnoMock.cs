using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGA_ITEA.Models
{
    public class AlumnoMock
    {
        public string RFE { get; set; }
        public string Nombre { get; set; }
        public string FechaRegistro { get; set; }
        public string Promedio { get; set; }
        public string Modulos { get; set; }
        
        // Atributos de Agrupación y Operativa
        public string UnidadOperativa { get; set; }
        public string CirculoEstudio { get; set; }
        
        // Estatus visual (Completo, Faltan Doc, etc)
        public string Estatus { get; set; } 
    }
}
