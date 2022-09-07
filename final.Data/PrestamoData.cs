using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using final.dominio;

namespace final.Data
{
   public class PrestamoData
    {



        string cadenaConexion = "server=PC303\\PAREDES; Database=Final2; Integrated Security = true";


        public List<Prestamo> Listar()
        {
            var listado = new List<Prestamo>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("Select * From Prestamo", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Prestamo prest;
                            while (lector.Read())
                            {
                                prest = new Prestamo();
                                prest.ID = int.Parse(lector[0].ToString());
                                prest.Numero = lector[1].ToString();

                                listado.Add(prest);
                            }
                        }
                    }
                }
            }
            return listado;
        }


    }
}
