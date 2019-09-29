using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }

}
