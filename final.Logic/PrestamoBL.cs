using System;
using System.Collections.Generic;
using final.Data;

using final.dominio;



namespace final.Logic
{
    public static class PrestamoBL
    {

        public static List<Prestamo> Listar()
        {
            var prestData = new PrestamoData();
            return prestData.Listar();
        }

    }
}
