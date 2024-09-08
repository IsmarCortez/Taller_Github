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

        public string eliminarQuery(int llave)
        {
            string sql = "DELETE FROM vehiculos WHERE id_vehiculo = " + llave + ";";
            Console.WriteLine(sql);
            return sql;
        }


        /***************************************************************************************************************/


        /**********************************Marco Alejandro Monroy***********************************************************/
        /**********************************Modificar************************************************************************/

        /*******************************************************************************************************************/
    }
}
