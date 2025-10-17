using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Mysqlx.Crud;
using System.Text.RegularExpressions;

namespace GestionCelulares
{
    public class ConexionBD
    {
        //datos de conexion a la bd. hay que escribir el nombre de la bd tal cual como la creamos en xampp

        private string conexion = "Server=localhost;Database=gestion_celulares;Uid=root;Pwd=;";

        //metodo que vamos a usar para cargar los datos en la bd
        public bool AltaCelular(string marca, string modelo,double precio, int stock)//escribimos los datos que necesitamos para crear un celular RESPETANDO LOS TIPOS DE DATOS QUE PUSIMOS EN LA BD
        {
            //en una query de insercion de datos en la tabla Celulares
            string consulta = "INSERT INTO `celulares`(`Modelo`, `Precio`, `Stock`, `Marca`) VALUES( @Modelo, @Precio, @Stock, @Marca)";


            try
            {
                //crea una nueva conexion con la bd
                using (MySqlConnection conectar = new MySqlConnection(conexion))
                {
                    conectar.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conectar))
                    {
                        //@nombre del campo que funciona como "variable" de la query consulta
                        //variable pasada por parametro que contiene el dato que quiero guardar en el campo
                        comando.Parameters.AddWithValue("@Modelo", modelo);
                        comando.Parameters.AddWithValue("@Precio", precio);
                        comando.Parameters.AddWithValue("@Stock", stock);
                        comando.Parameters.AddWithValue("@Marca", marca);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            //excepciones o deteccion de errores
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
                return false;
            }
        }

       public DataTable VerCelulares()
        {

            DataTable tabla =new DataTable();
            string consultaSQL = "SELECT * FROM `celulares`";
            try
            {
                using (MySqlConnection conectar = new MySqlConnection(conexion))
                {
                    conectar.Open();
                    using (MySqlCommand comando = new MySqlCommand(consultaSQL, conectar))
                    {
                        //cambiar los datos de una tabla mysql a una datatable
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }

            return tabla;
        }
        //eliminar y modificar. utilizar los radiobutons
        public bool EliminarCelular()
        {
            return false;
        }
        
    }
}
