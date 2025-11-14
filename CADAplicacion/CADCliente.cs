using CADAplicacion.DsAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADAplicacion
{
    public class CADCliente
    {
        private static ClienteTableAdapter adaptador = new ClienteTableAdapter();
        public static DsAplicacionComercial.ClienteDataTable getData()
        {
            return adaptador.GetData();
        }
    }
}
