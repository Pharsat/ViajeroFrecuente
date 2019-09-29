using System;
using Entidades;

namespace Negocio
{
    public class MillasControlador : IMillasControlador
    {
        private static IPasajeroControlador pasajeroControlador;
        private static IAliadoControlador aliadoControlador;
        private static IMovimientoControlador movimientoControlador;

        public Movimiento RedimirMillas(Guid idPasajero, int cantidadMillas)
        {
            Pasajero pasajero = pasajeroControlador.ObtenerPasajero(idPasajero);

            pasajeroControlador.ValidaQueHayaMillasDisponibles(pasajero, cantidadMillas);

            return new Movimiento
            {
                Pasajero = pasajero,
                Aliado = null,
                Millas = cantidadMillas,
                FechaUso = DateTime.Now,
                TipoMovimiento = TipoMovimiento.Redencion
            };
        }

        public Movimiento SumarMillas(Guid idPasajero, Guid idAliado, int cantidadMillas)
        {
            return new Movimiento
            {
                Pasajero = pasajeroControlador.ObtenerPasajero(idPasajero),
                Aliado = aliadoControlador.ObtenerAliado(idAliado),
                Millas = cantidadMillas,
                FechaUso = DateTime.Now,
                TipoMovimiento = TipoMovimiento.Suma
            };
        }

        public void CalcularMillas(Movimiento movimiento)
        {
            switch (movimiento.TipoMovimiento)
            {
                case TipoMovimiento.Redencion:
                    movimiento.Pasajero.Millas -= movimiento.Millas;
                    break;
                case TipoMovimiento.Suma:
                    movimiento.Pasajero.Millas += movimiento.Millas;
                    break;
                default:
                    throw new Exception("Tipo de movimiento no reconocido.");
            }
            pasajeroControlador.ActualizarPasajero(movimiento.Pasajero);
            movimientoControlador.GuardarMovimiento(movimiento);
        }
    }
}
