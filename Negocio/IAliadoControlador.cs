using System;
using Entidades;

namespace Negocio
{
    public interface IAliadoControlador
    {
        Aliado ObtenerAliado(Guid idAliado);
    }
}