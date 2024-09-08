using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Consulta : Form
    {
        String tabla = "vehiculos";
        Controlador cn = new Controlador();
        public Consulta()
        {
            InitializeComponent();
            string tabla = "vehiculos";
            string campo1 = "fabricante";


            llenarse(tabla, campo1);


        }


        /****************************Fernando Jose Garcia De León****************************************************************/
        /*****CONSULTAR ******/

        public void actualizardatagridview()
        {
            DataTable dt = cn.llenarTbl(tabla);
            Dgv_consulta.DataSource = dt;
        }


        /************************************************************************************************************************/


        /**********Fernando Jose Garcia De León**********************************************************************************/
        /*****CONSULTAR ******/
        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            actualizardatagridview();
        }
        /*************************************************************************************************************************/

        private void label2_Click(object sender, EventArgs e)
        {

        }


        /**********************************Brandon Alejandro Boch Lopez************************************************************/
        /************************************INGRESAR******************************************************************************/
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string codigotext = txt_codigo.Text;
            int codigo = Convert.ToInt32(codigotext);
            string modelo = txt_modelo.Text;
            string tipo = txt_tipo.Text;
            string fabricante = (string)cmb_auto.SelectedItem;
            string estado = txt_estadoVehiculo.Text;
            int estadovehiculo = Convert.ToInt32(estado);

            try

            {

                cn.saveVehiculo(codigo, modelo, tipo, fabricante, estadovehiculo);
                MessageBox.Show($"Datos recibidos: Código: {codigo}, Nombre: {modelo}, Puesto: {tipo}, Departamento: {fabricante}, Estado: {estadovehiculo}");

                MessageBox.Show("Registro Agregado correctamente :)");
            }
            catch
            {
                MessageBox.Show("Registro No ingresado");
            }
        }
        /**************************************************************************************************************************/


        /*****************************************Gabriela Alejandra Suc Gomez*****************************************************/
        /************************************ELIMINAR******************************************************************************/
        private void button2_Click(object sender, EventArgs e)
        {

           
        }
        /*******************************************************************************************************************/


        /**********************************Kateryn Johann De Leon***********************************************************/
        /**********************************REFRESCAR************************************************************************/
       
        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagridview();
        }
        /*******************************************************************************************************************/

        private void Dgv_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = Dgv_consulta.CurrentRow.Cells[0].Value.ToString();
            txt_modelo.Text = Dgv_consulta.CurrentRow.Cells[1].Value.ToString();
            txt_tipo.Text = Dgv_consulta.CurrentRow.Cells[2].Value.ToString();


            //cmb_auto = Dgv_consulta.CurrentRow.Cells[3].Value.ToString();

            // Convertir el valor de la celda en el valor correspondiente del ComboBox
            string autoValue = Dgv_consulta.CurrentRow.Cells[3].Value.ToString();

            // Si tu ComboBox tiene valores asociados, selecciona el ítem correspondiente
            cmb_auto.SelectedItem = autoValue; // Esto selecciona el valor del ComboBox que coincida con autoValue

            txt_estadoVehiculo.Text = Dgv_consulta.CurrentRow.Cells[4].Value.ToString();

        }

        /**********************************Marco Alejandro Monroy***********************************************************/
        /**********************************Modificar************************************************************************/

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        /*******************************************************************************************************************/


        /*********************Ismar Leonel Cortez Sanchez -0901-21-560***********************/
        /***********************Combo box inteligente*************************************/
        public void llenarse(string tabla, string campo1)
        {


            string tbl = tabla;
            string cmp1 = campo1;
            //            string cmp2 = campo2;



            cmb_auto.ValueMember = "fabricante";
            cmb_auto.DisplayMember = "vehiculos";

            string[] items = cn.items(tabla, campo1);
            /*Accede a la capa controlador en donde los 3 parametros*/
            /*Aqui viene a parar de controlador*/

            /*Con este for se recorre lo del array obtenido*/

            /*
             vista -> controlador -> modelos
             vista <- controlador <- modelos
 

             */

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        cmb_auto.Items.Add(items[i]);
                    }
                }

            }

            /*se guardan los datos que vengan.*/
            /*Es para guardarla y que sirvan como referencia, y
             se tiene la coleccion*/

            var dt2 = cn.enviar(tabla, campo1);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]));


            }


            cmb_auto.AutoCompleteCustomSource = coleccion;
            cmb_auto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_auto.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
        /********************************************************************************************/

        private void cmb_auto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
