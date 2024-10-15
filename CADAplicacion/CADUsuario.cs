using CADAplicacion.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADAplicacionComercial
{
    public class CADUsuario
    {
        private static UsuarioTableAdapter adaptador = new UsuarioTableAdapter();
        public static bool ValidaUsuario(string IDUsuario, string Clave)
        {
            return (int)(adaptador.ValidaUsuario(IDUsuario, Clave)) == 1;

        }
    }
}
