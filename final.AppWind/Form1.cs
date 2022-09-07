using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final.Logic;
using final.dominio;




namespace final.AppWind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }


      

    public void cargarDatos()
        {
            var listado = PrestamoBL.Listar();
            listado.Insert(0, new Prestamo
            {
                Numero = "--SELECCIONE--"


            });
            cboIdPres.DataSource = listado;
            cboIdPres.DisplayMember = "Numero";
            cboIdPres.ValueMember = "ID";












        }

    }
}
