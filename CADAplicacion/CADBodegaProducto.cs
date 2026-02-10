using CADAplicacion.DsAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CADAplicacion
{
    public class CADBodegaProducto
    {
        public int IDBodega { get; set; }
        public int IDProducto { get; set; }
        public int Stock { get; set; }
        public int Minimo { get; set; }
        public int Maximo { get; set; }
        public int DiasReposicion { get; set; }
        public int MinimoOrdenar { get; set; }

        private static BodegaProductoTableAdapter adaptador = new BodegaProductoTableAdapter();

        public static CADBodegaProducto GetBodegaProductoByIDBodegaAndIDProducto(int idBodega, int idProducto)
        {
            CADBodegaProducto miBodegaProducto = null;
            DsAplicacionComercial.BodegaProductoDataTable mitabla=
                adaptador.GetBodegaProductoByIDBodegaAndIDProducto(idBodega, idProducto);
            if (mitabla.Rows.Count == 0) return miBodegaProducto;
            DsAplicacionComercial.BodegaProductoRow miFila = (DsAplicacionComercial.BodegaProductoRow)mitabla.Rows[0];
            miBodegaProducto = new CADBodegaProducto();
            miBodegaProducto.IDBodega = miFila.IDBodega;
            miBodegaProducto.IDProducto = miFila.IDProducto;
            miBodegaProducto.Stock = (int)miFila.Stock;
            miBodegaProducto.Minimo = (int)miFila.Minimo;
            miBodegaProducto.Maximo = (int)miFila.Maximo;
            miBodegaProducto.DiasReposicion = miFila.DiasReposicion;
            miBodegaProducto.MinimoOrdenar = (int)miFila.CantidadMinima;
            
            return miBodegaProducto;

        }
        public static void UpdateBodegaProducto(int IDBodega, int IDProducto, double Minimo,double Maximo,int DiasReposicion,double CantidadMinima)
        {
            try
            {
                adaptador.InsertBodegaProducto(IDBodega, IDProducto, Minimo, Maximo, DiasReposicion,CantidadMinima);
             
            }
            catch (Exception)
            {
                adaptador.UpdateBodegaProducto(Minimo, Maximo, DiasReposicion, CantidadMinima, IDBodega, IDProducto);
                
            }
            
        }
    }
}
