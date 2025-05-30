namespace Repaso_Formularios
{
    public partial class FormCargarDatos : Form
    {
        public FormCargarDatos()
        {
            InitializeComponent();

        }


        private void btn_cargar_Click(object sender, EventArgs e)
        {
            string nombre;
            int edad;
            string genero;

            nombre = txt_nombre.Text;
            genero = cmb_genero.Text;            
            
            if (nombre.Length < 3 )//con esta sentencia verifico que el dato de nombre tenga al menos 3 letras
            {
                MessageBox.Show("El nombre debe tener al menos 3 letras","Error de nombre");
            }
            else if (int.TryParse(txt_edad.Text, out edad) == false)//intento parsear a entero, devuelve un bool que da True en caso de ser posible y guarda el valor en la variable edad 
            {
                MessageBox.Show("El dato de edad debe ser un numero entero", "Error de edad");
            }
            else if (genero==string.Empty)//con esta sentencia verifico que no haya dejado el combobox en blanco
            {
                MessageBox.Show("Elija un genero de la lista", "Error de genero");
            }
            else //solo si pasa correctamente todas las validaciones de datos muestra el mensaje en la lbl
            {
                lbl_mostrarNombre.Text = $"Nombre: {nombre}\nEdad: {edad}\nGenero: {genero}";
            }                   

        }
    }
}
