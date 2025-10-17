namespace GestionCelulares
{
    public partial class FormAlta : Form
    {
        //crear un objeto de tipo COnexionBD para poder usar los metodos de la clase
        private ConexionBD nuevaConexion;
        public FormAlta()
        {
            InitializeComponent();
        }

        private void Alta_Click(object sender, EventArgs e)
        {

        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            nuevaConexion = new ConexionBD();


            string marca = txt_marca.Text;
            string modelo = txt_modelo.Text;
            double precio = double.Parse(txt_precio.Text);
            int stock = int.Parse(txt_stock.Text);

            //nuevaConexion.AltaCelular(marca, modelo, precio, stock);

            if (nuevaConexion.AltaCelular(txt_marca.Text, txt_modelo.Text, double.Parse(txt_precio.Text), int.Parse(txt_stock.Text)))
            {
                txt_marca.Clear();
                txt_modelo.Clear();
                txt_precio.Clear();
                txt_stock.Clear();

            }

        }

        //modificar celular - mostrar celulares - eliminar celular
        //repasar tryparse

    }
}
