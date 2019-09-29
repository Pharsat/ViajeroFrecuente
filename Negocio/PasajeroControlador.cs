using System;
using System.Collections.Generic;
using System.Text;
using CapaAccesoDatos;
using Entidades;

namespace Negocio
{
    public class PasajeroControlador : IPasajeroControlador
    {
        private static IRepositorioPasajero _datos;

        public PasajeroControlador()
        {
            _datos = new RepositorioPasajero();
        }

        public bool ValidaQueHayaMillasDisponibles(Pasajero pasajero, int cantidadMillas)
        {
            if (pasajero.Millas > cantidadMillas)
            {
                throw new Exception("Las millas a redimir son insuficientes");
            }
            return true;
        }

        public Pasajero ObtenerPasajero(Guid idPasajero)
        {
            return _datos.ObtenerPasajero(idPasajero);
        }

        public void ActualizarPasajero(Pasajero pasajero)
        {
            _datos.ActualizarPasajero(pasajero);
        }
    }
}
