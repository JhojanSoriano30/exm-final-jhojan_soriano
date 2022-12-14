using System;

namespace final.dominio
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dirección { get; set; }
        public string Referencia { get; set; }
        public int IdTipoCliente { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public bool Estado { get; set; }


        public string NombreCompleto
        {

            get
            {
                return this.Nombres + " " + this.Apellidos;
            }


        }

    }
}
