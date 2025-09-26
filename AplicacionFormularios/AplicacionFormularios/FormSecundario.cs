using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionFormularios
{
    public partial class FormSecundario : Form
    {
        string nombre;
        string apellido;
        int edad;
        public FormSecundario()
        {
            InitializeComponent();
        }
        
        public FormSecundario(string nombre, string apellido, int edad)
        {
            //inicializo los atributos del formulario
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        private void FormSecundario_Load(object sender, EventArgs e)
        {
            //mostrar datos
            //con una clase estatica
            txt_mostrarDatos.Text = $"Nombre: {AccionesFormularios.Nombre} Apellido: {AccionesFormularios.Apellido} Edad: {AccionesFormularios.Edad}";

            //desde el constructor
            txt_mostrarDatos.Text= $"Nombre: {this.nombre} Apellido: {this.apellido} Edad: {this.edad}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//cerrar formulario
        }
    }
}
