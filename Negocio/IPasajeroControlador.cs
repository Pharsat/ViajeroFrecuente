using System;
using Entidades;

namespace Negocio
{
    public interface IPasajeroControlador
    {
        bool ValidaQueHayaMillasDisponibles(Pasajero pasajero, int cantidadMillas);
        Pasajero ObtenerPasajero(Guid idPasajero);
        void ActualizarPasajero(Pasajero pasajero);
    }
}