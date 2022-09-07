using System;
using System.Collections.Generic;
using System.Text;
using final.Data;
using final.dominio;



namespace final.Logic
{
    public static class DetallePrestamoBL
    {

        public static List<DetallePrestamo> Listar()
        {
            var prestData = new DetallePrestamoData();
            return prestData.Listar();
        }

    }
}
