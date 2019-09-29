using System;
using System.Collections.Generic;
using System.Text;
using CapaAccesoDatos;
using Entidades;

namespace Negocio
{
    public class MovimientoControlador : IMovimientoControlador
    {
        private static IRepositorioMovimiento _datos;

        public MovimientoControlador()
        {
            _datos = new RepositorioMovimiento();
        }

        public void GuardarMovimiento(Movimiento movimiento)
        {
            _datos.GuardarMovimiento(movimiento);
        }
    }
}
