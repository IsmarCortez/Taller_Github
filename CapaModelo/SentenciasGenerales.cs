using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class SentenciasGenerales
    {
        protected Conexion conn;

        public SentenciasGenerales()
        {
            this.conn = new Conexion();
        }

        /**********************************Brandon Alejandro Boch Lopez*********************************************/
        /**********************************GetQuery*****************************************************************/
        public string getQuery(int codigo, string modelo, string tipo, string fabricante, int estadovehiculo)
        {
            string sql = "insert into vehiculos(id_vehiculo, modelo, tipo, fabricante, estado_vehiculo) values('" + codigo + "', '" + modelo + "', '" + tipo + "', '" + fabricante + "', '" + estadovehiculo + "')";
            Console.WriteLine(sql);
            return sql;
        }

        /*************************************************************************************************************/


        public void insertarSQL(string query)
        {
            try
            {
                OdbcCommand cmd = new OdbcCommand(query, this.conn.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /*************************Gabriela Alejandra Suc Gomez*********************************************************/
        /*************************Eliminar******************************************************************************/

        /***************************************************************************************************************/


        /**********************************Marco Alejandro Monroy***********************************************************/
        /**********************************Modificar************************************************************************/

        /*******************************************************************************************************************/
    }
}
