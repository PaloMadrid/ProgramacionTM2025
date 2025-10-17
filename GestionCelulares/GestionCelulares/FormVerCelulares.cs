using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionCelulares
{
    public partial class FormVerCelulares : Form
    {
        //necesito crear un objeto tipo ConexionBD para usar cualquiera de los metodos de la clase
        private ConexionBD nuevaConexion = new ConexionBD();
        //private DataTable tabla;
        public FormVerCelulares()
        {
            InitializeComponent();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormVerCelulares_Load(object sender, EventArgs e)
        {
            //al crear el metodo verCelulares escribimos que devolvia una Datatable, por lo que para poder llamarlo debemos guardarlo en una variable del mismo tipo
           DataTable tabla = nuevaConexion.VerCelulares();

            if (tabla != null)
            {
                //carga los datos de la DataTable en el datagrid
                dtg_verCelulares.DataSource = tabla;
            }
        }
    }
}
