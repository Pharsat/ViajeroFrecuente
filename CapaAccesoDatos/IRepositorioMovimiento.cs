using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace CapaAccesoDatos
{
    public interface IRepositorioMovimiento : IRepositorio
    {
        void GuardarMovimiento(Movimiento movimiento);
    }
}
