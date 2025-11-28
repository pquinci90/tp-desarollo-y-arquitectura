using Entity;
using Entity.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class SesionManageUtil
    {
        public static UsuarioEntity UsuarioActual { get; private set; }

        public static void IniciarSesion(UsuarioEntity usuario)
        {
            UsuarioActual = usuario;
        }

        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
        public static bool EsAdmin()
        {
            if (UsuarioActual != null)
            {
                return UsuarioActual.Admin;
            }
            return false;
        }
        public static List<EventoEntity> Carrito { get; set; } = new ();

    }
}
