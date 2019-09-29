using System;
using Entidades;

namespace Negocio
{
    public interface IMillasControlador
    {
        Movimiento RedimirMillas(Guid idPasajero, int cantidadMillas);
        Movimiento SumarMillas(Guid idPasajero, Guid idAliado, int cantidadMillas);
        void CalcularMillas(Movimiento movimiento);
    }
}