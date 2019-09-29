using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace CapaAccesoDatos
{
    public interface IRepositorioPasajero : IRepositorio
    {
        Pasajero ObtenerPasajero(Guid idPasajero);
        void ActualizarPasajero(Pasajero pasajero);
    }
}
