using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Movimiento
    {
        public Pasajero Pasajero { get; set; }
        public Aliado Aliado { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }
        public DateTime FechaUso { get; set; }
        public int Millas { get; set; }
    }
}
