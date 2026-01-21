using CADAplicacion.DsAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADAplicacion
{
    public class CADBarra
    {
        private static BarraTableAdapter adaptadaror= new BarraTableAdapter();

        public static bool ExisteBarra(long  barra)
        {
            var resultado = adaptadaror.ExisteBarra(barra);
            if (resultado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void InsertarBarra(int  IDProducto, long Barra)
        {
            adaptadaror.InsertBarra(IDProducto, Barra);
        }
        public static void DeleteBarra(long Barra)
        {
            adaptadaror.DeleteBarra(Barra);
        }
    }
}
