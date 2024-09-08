using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data.Odbc;
using System.Data;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        /*************Fernando Jose Garcia de León********************************/
        /*************Consulta****************************************************/

        /************************************************************************/


        /**************************Brandon Alejandro Boch Lopez******************/
        /*********************Guardar Vehiculo***********************************/
        public void saveVehiculo(int codigo, string modelo, string tipo, string fabricante, int estadovehiculo)
        {

        }
        /************************************************************************/


        /*****************Gabriela Alejandra Suc Gomez***************************/
        /*********************Eliminar vehiculo**********************************/
        public void eliminar(int llave)
        {
            sn.eliminar(llave);
        }
        /************************************************************************/


        /**********************************Marco Alejandro Monroy***********************************************************/
        /**********************************Modificar************************************************************************/
        public void modificar(int id, string n, string p, string d, int es)
        {

        }
        /*******************************************************************************************************************/


        /*********************Ismar Leonel Cortez Sanchez -0901-21-560************/
        /***********************Combo box inteligente*****************************/

        public string[] items(string tabla, string campo1)
        {
            string[] Items = sn.llenarCmb(tabla, campo1);
            /*Este arreglo lo obtiene y retorna de la clase senencias del modelo*/
            return Items;

            /*Aqui viene a parar lo de sentencias*/


        }

        public DataTable enviar(string tabla, string campo1)
        {


            /**/
            var dt1 = sn.obtener(tabla, campo1);

            return dt1;
        }
        /**************************************************************************/
    }
}
