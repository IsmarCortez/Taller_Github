using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;


namespace CapaModelo
{
    public class Sentencias : SentenciasGenerales
    {
        Conexion con = new Conexion();

        /*************************Fernando Jose Garcia De Leon*********************************************************/
        /*************************Consulta*****************************************************************************/
        public OdbcDataAdapter llenarTbl(string tabla)
        {
            string sql = "SELECT* FROM " + tabla + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        /**************************************************************************************************************/


        /*************************Brandon Alejandro Boch Lopez*********************************************************/
        /*************************Guardar******************************************************************************/
        public void guardar(int codigo, string modelo, string tipo, string fabricante, int estadovehiculo)
        {
            string query = this.getQuery(codigo, modelo, tipo, fabricante, estadovehiculo);
            this.insertarSQL(query);
        }

        /***************************************************************************************************************/


        /*************************Gabriela Alejandra Suc Gomez*********************************************************/
        /*************************Eliminar******************************************************************************/
        public void eliminar(int llave)
        {
            string query = this.eliminarQuery(llave);
            this.insertarSQL(query);
        }
        /***************************************************************************************************************/


        /**********************************Marco Alejandro Monroy***********************************************************/
        /**********************************Modificar************************************************************************/
        public void modificar(int id, string n, string p, string d, int es)
        {

        }
        /*******************************************************************************************************************/


        /*******************Ismar Leonel Cortez Sanchez  -0901-21-560*******************************************************/
        /****************************Combo box inteligente******************************************************************/


        public string[] llenarCmb(string tabla, string campo1)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT DISTINCT " + campo1 + " FROM " + tabla;
            /*La sentencia consulta el modelo de la base de datos con cada campo*/
            /*En la capa modelo se consulta*/

            /*Se guarda la consulta de los campos que realizo en un arreglo*/
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Campos[i] = reader.GetValue(0).ToString();
                    i++;
                    /*Todo el recorrido de los campos
                     mientras tenga que leer todo se va almacenando en campos
                    de tipo string*/

                    /*Esto lo envia a controlador que lo guarda en items*/


                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }
            return Campos;

        }

        public DataTable obtener(string tabla, string campo1)
        {

            string sql = "SELECT DISTINCT " + campo1 + " FROM " + tabla;

            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        /****************************************************************************************************************/
    }
}
