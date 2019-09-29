using System;
using System.Collections.Generic;
using System.Text;
using CapaAccesoDatos;
using Entidades;

namespace Negocio
{
    public class AliadoControlador : IAliadoControlador
    {
        private IRepositorioAliado _datos;

        public AliadoControlador()
        {
            _datos = new RepositorioAliado();
        }

        public Aliado ObtenerAliado(Guid idAliado)
        {
            return _datos.ObtenerAliado(idAliado);
        }
    }
}
