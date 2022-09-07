using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using final.dominio;

namespace final.Data
{
    public  class DetallePrestamoData
    {

        string cadenaConexion = "server=PC303\\PAREDES; Database=Final2; Integrated Security = true";





        public List<DetallePrestamo> Listar()
        {
            var listado = new List<DetallePrestamo>();

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("Select * from DetallePrestamo", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            DetallePrestamo detalle;
                            while (lector.Read())
                            {
                                detalle = new DetallePrestamo();

                                detalle.ID = int.Parse(lector[0].ToString());
                                detalle.FechaVencimiento = DateTime.Parse(lector[1].ToString());
                                detalle.ImporteCuota = decimal.Parse(lector[2].ToString());
                                detalle.ImporteInteres = decimal.Parse(lector[3].ToString());
                                decimal tot = (detalle.ImporteCuota + detalle.ImporteInteres);
                                tot = decimal.Parse(lector[4].ToString());

                                listado.Add(detalle);

                            }

                        }

                    }

                }

            }

            return listado;
        }











        public DetallePrestamo BuscarPorId(int id)
        {
            var detalle = new DetallePrestamo();


            using (var conexion = new SqlConnection(cadenaConexion))
            {

                conexion.Open();
                using (var comando = new SqlCommand("Select * from DetallePrestamo where IdPrestamo = @id", conexion))
                {

                    comando.Parameters.AddWithValue("@id", id);
                    using (var lector = comando.ExecuteReader())
                    {

                        if (lector != null && lector.HasRows)
                        {
                            lector.Read();
                            detalle = new DetallePrestamo();

                            detalle.ID = int.Parse(lector[0].ToString());
                            detalle.FechaVencimiento = DateTime.Parse(lector[1].ToString());
                            detalle.ImporteCuota = decimal.Parse(lector[2].ToString());
                            detalle.ImporteInteres = decimal.Parse(lector[3].ToString());
                            decimal tot = (detalle.ImporteCuota + detalle.ImporteInteres);
                            tot = decimal.Parse(lector[4].ToString());



                        }
                    }

                }

            }
            return detalle;
        }


    }
}
