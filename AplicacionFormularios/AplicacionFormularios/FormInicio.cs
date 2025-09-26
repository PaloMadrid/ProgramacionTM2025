namespace AplicacionFormularios
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btn_cargarInfo_Click(object sender, EventArgs e)
        {
            ///con una clase estatica intermediaria
            /*pasos:
             crear clase estatica
            en dicha clase crear propiedades publicas y estaticas por cada dato que necesite guardar
            en el componente que genere la accion (en este caso btn_cargarInfo) guardar los datos en las propiedades establecidas en la clase estatica
            abrir el formulario secundario
             */
            AccionesFormularios.Nombre = txt_nombre.Text;
            AccionesFormularios.Apellido= txt_apellido.Text;
            AccionesFormularios.Edad=(int)num_edad.Value;

            FormSecundario miForm=new FormSecundario();
            miForm.ShowDialog();


            //cargar datos con constructor
            /*pasos:
             * EN FORMsECUNDARIO
             * crear un atributo para cada dato que necesite almacenar. 
             * crear el constructor que inicialice tantos parametros como datos necesite pasar al form secundario
             * EN FORMpRINCIPAL
             * llamar al constructor de formSecundario usando de parametros lo almacenado en cada componente
             * 
             * ACLARACION: ESTO SE PODRIA SIMPLIFICAR MUCHISIMO SI TUVIESEMOS UNA CLASE "PERSONA" CON ESTOS ATRIBUTOS, DE ESTA MANERA EN LUGAR DE PASAR VARIOS DATOS EL UNICO PARAMETRO QUE NECESITARIAMOS ES UN OBJETO DE TIPO PERSONA
             */

            FormSecundario formSecundario = new FormSecundario(txt_nombre.Text,txt_apellido.Text,(int)num_edad.Value);
            formSecundario.ShowDialog();
        }
    }
}
