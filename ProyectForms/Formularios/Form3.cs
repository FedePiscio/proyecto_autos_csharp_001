using ProyectForms.ClaseEspace;
using ProyectForms.ClasesContexto;
using ProyectForms.ClasesTesla;
using Proyecto.ClasesTesla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectForms.Formularios
{
    /// <summary>
    /// CLASE FORMULARIO 3:
    /// En este formulario vamos a incorporar todas las funcionalidades relativas a selecciones un objeto de la lista, visualizar datos relacionados,
    /// eliminar, escanear, mover o realizar recorrido con el objeto, recargar bateria o combustible.
    /// Los metodos similares a los anteriores tienen mismas caracteristicas a las definidas anteriormete.
    /// La metodologia es la misma que a medida que se realizan los pasos por el usuario se iran habilitando las opciones para seguir ejecutando la operacion.
    /// </summary>
    public partial class Form3 : Form
    {
        //- SITUACION INICIAL al ejecutar el formulario.
        public Form3()
        {
            InitializeComponent();
            refrescarLista();
            textBoxForm3.Enabled = false;
            textBoxForm3.Text = "***** Seleccione un vehiculo sobre el cual quiere operarar *****";
            groupBoxOpciones.Enabled = false;
            buttonEjecutar.Enabled = false;

        }

        //- REFRESCAR LISTA: similar a lo anterior.
        public void refrescarLista()
        {

            dataGridView2.Rows.Clear();

            foreach (Object objeto in Contexto.ListaObjetos)
            {
                dataGridView2.Rows.Add(); 

                int filaIndex = dataGridView2.Rows.Count - 1; 
                if (objeto is TeslaModeloS)
                {
                    TeslaModeloS objetoTesla = (TeslaModeloS)objeto;


                    dataGridView2.Rows[filaIndex].Cells["Column1NId"].Value = objetoTesla.GetNId;
                    dataGridView2.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoTesla.GetModelo;
                    dataGridView2.Rows[filaIndex].Cells["Column2Anio"].Value = objetoTesla.GetAnio;
                    dataGridView2.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoTesla.GetDuenio;
                    dataGridView2.Rows[filaIndex].Cells["Column4"].Value = objetoTesla.GetKmActual;
                    dataGridView2.Rows[filaIndex].Cells["Column5Color"].Value = objetoTesla.GetColor;


                }
                else if (objeto is TeslaModeloX)
                {
                    TeslaModeloX objetoTesla = (TeslaModeloX)objeto;

                    dataGridView2.Rows[filaIndex].Cells["Column1NId"].Value = objetoTesla.GetNId;
                    dataGridView2.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoTesla.GetModelo;
                    dataGridView2.Rows[filaIndex].Cells["Column2Anio"].Value = objetoTesla.GetAnio;
                    dataGridView2.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoTesla.GetDuenio;
                    dataGridView2.Rows[filaIndex].Cells["Column4"].Value = objetoTesla.GetKmActual;
                    dataGridView2.Rows[filaIndex].Cells["Column5Color"].Value = objetoTesla.GetColor;
                }
                else if (objeto is TeslaCybertruck)
                {
                    TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;

                    dataGridView2.Rows[filaIndex].Cells["Column1NId"].Value = objetoTesla.GetNId;
                    dataGridView2.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoTesla.GetModelo;
                    dataGridView2.Rows[filaIndex].Cells["Column2Anio"].Value = objetoTesla.GetAnio;
                    dataGridView2.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoTesla.GetDuenio;
                    dataGridView2.Rows[filaIndex].Cells["Column4"].Value = objetoTesla.GetKmActual;
                    dataGridView2.Rows[filaIndex].Cells["Column5Color"].Value = objetoTesla.GetColor;
                }
                else if (objeto is EspaceStarship)
                {
                    EspaceStarship objetoEspaceX = (EspaceStarship)objeto;


                    dataGridView2.Rows[filaIndex].Cells["Column1NId"].Value = objetoEspaceX.GetNId;
                    dataGridView2.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoEspaceX.GetModelo;
                    dataGridView2.Rows[filaIndex].Cells["Column2Anio"].Value = objetoEspaceX.GetAnio;
                    dataGridView2.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoEspaceX.GetEmpresa;
                    dataGridView2.Rows[filaIndex].Cells["Column4"].Value = objetoEspaceX.GetHsActual;
                    dataGridView2.Rows[filaIndex].Cells["Column5Color"].Value = objetoEspaceX.GetColor;
                }
                else if (objeto is EspaceFalcon9)
                {
                    EspaceFalcon9 objetoEspaceX = (EspaceFalcon9)objeto;


                    dataGridView2.Rows[filaIndex].Cells["Column1NId"].Value = objetoEspaceX.GetNId;
                    dataGridView2.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoEspaceX.GetModelo;
                    dataGridView2.Rows[filaIndex].Cells["Column2Anio"].Value = objetoEspaceX.GetAnio;
                    dataGridView2.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoEspaceX.GetEmpresa;
                    dataGridView2.Rows[filaIndex].Cells["Column4"].Value = objetoEspaceX.GetHsActual;
                    dataGridView2.Rows[filaIndex].Cells["Column5Color"].Value = objetoEspaceX.GetColor;
                }

            }
        }

        //- VISUALIZACION DE DATOS: metodo que permite visualizar los datos del objeto que se selecciona de la grilla, segun el tipo de objeto que se trate.
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //- Se guarda el indice seleccionado en una variable del contexto para poder trabajar a lo largo de la ejecucion de las operaciones.
            Contexto.Indice = e.RowIndex;
            int index = Contexto.Indice;

            //- Al tener seleccionado un objeto se habilita las diferentes opciones con las que se podra realizar operaciones.
            groupBoxOpciones.Enabled = true;
            buttonEjecutar.Enabled = true;
            radioButtonEscanear.Checked = true;

            //- Definimos segun el objeto la estructura que se visualizara en pantalla.
            object objeto = Contexto.ListaObjetos[index];

            if (Contexto.ListaObjetos[index] is TeslaModeloX)
            {
                TeslaModeloX objetoTesla = (TeslaModeloX)objeto;

                textBoxForm3.Text = $"**** DATOS SELECCIONADOS: " +
                    $"\r\n" +
                    $"\r\nLARGO:-- {Contexto.ListaObjetos.Count} -- INDICE: {index}" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nAÑO:-- {objetoTesla.GetAnio}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nCOLOR:-- {objetoTesla.GetColor} " +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nKM-ULTIMO SERVICIO:-- {objetoTesla.GetKmUltimoServicio}" +
                    $"\r\nKM-SIN SERVICIO:-- {objetoTesla.GetKmActual - objetoTesla.GetKmUltimoServicio}" +
                    $"\r\nAUTONOMIA S/CARGA BATERIA:-- {objetoTesla.GetAutonomia} KMS" +
                    $"\r\nCARGA DE BATERIA:-- {objetoTesla.GetCarga} % " +
                    $"\r\nASIENTOS:-- {objetoTesla.GetAsientos}" +
                    $"\r\nREQUERIMIENTO DE SERVICIOS C/:-- {objetoTesla.GetService} KMS" +
                    $"\r\n" +
                    $"\r\n****";

            }
            else if (Contexto.ListaObjetos[index] is TeslaModeloS)
            {
                TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                textBoxForm3.Text = $"**** DATOS SELECCIONADOS: " +
                    $"\r\n" +
                    $"\r\nLARGO:-- {Contexto.ListaObjetos.Count} -- INDICE: {index}" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nAÑO:-- {objetoTesla.GetAnio}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nCOLOR:-- {objetoTesla.GetColor} " +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nKM-ULTIMO SERVICIO:-- {objetoTesla.GetKmUltimoServicio}" +
                    $"\r\nKM-SIN SERVICIO:-- {objetoTesla.GetKmActual - objetoTesla.GetKmUltimoServicio}" +
                    $"\r\nAUTONOMIA S/CARGA BATERIA:-- {objetoTesla.GetAutonomia} KMS" +
                    $"\r\nCARGA DE BATERIA:-- {objetoTesla.GetCarga} % " +
                    $"\r\nASIENTOS:-- {objetoTesla.GetAsientos}" +
                    $"\r\nREQUERIMIENTO DE SERVICIOS C/:-- {objetoTesla.GetService} KMS" +
                    $"\r\n" +
                    $"\r\n****";
            }
            else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
            {
                TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;

                textBoxForm3.Text = $"**** DATOS SELECCIONADOS: " +
                    $"\r\n" +
                    $"\r\nLARGO:-- {Contexto.ListaObjetos.Count} -- INDICE: {index}" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nAÑO:-- {objetoTesla.GetAnio}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nCOLOR:-- {objetoTesla.GetColor} " +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nKM-ULTIMO SERVICIO:-- {objetoTesla.GetKmUltimoServicio}" +
                    $"\r\nKM-SIN SERVICIO:-- {objetoTesla.GetKmActual - objetoTesla.GetKmUltimoServicio}" +
                    $"\r\nAUTONOMIA S/CARGA BATERIA:-- {objetoTesla.GetAutonomia} KMS" +
                    $"\r\nCARGA DE BATERIA:-- {objetoTesla.GetCarga} % " +
                    $"\r\nASIENTOS:-- {objetoTesla.GetAsientos}" +
                    $"\r\nREQUERIMIENTO DE SERVICIOS C/:-- {objetoTesla.GetService} KMS" +
                    $"\r\n" +
                    $"\r\n****";
            }
            else if (Contexto.ListaObjetos[index] is EspaceStarship)
            {
                EspaceStarship objetoTesla = (EspaceStarship)objeto;

                textBoxForm3.Text = $"**** DATOS SELECCIONADOS: " +
                    $"\r\n" +
                    $"\r\nLARGO:-- {Contexto.ListaObjetos.Count} -- INDICE: {index}" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nAÑO:-- {objetoTesla.GetAnio}" +
                    $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nCOLOR:-- {objetoTesla.GetColor} " +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetHsActual}" +
                    $"\r\nKM-ULTIMO SERVICIO:-- {objetoTesla.GetHsUltimoServicio}" +
                    $"\r\nKM-SIN SERVICIO:-- {objetoTesla.GetHsActual - objetoTesla.GetHsUltimoServicio}" +
                    $"\r\nAUTONOMIA S/CARGA BATERIA:-- {objetoTesla.GetAutonomia} Hs" +
                    $"\r\nCARGA DE BATERIA:-- {objetoTesla.GetTanqueCombustible} % " +
                    $"\r\nREQUERIMIENTO DE SERVICIOS C/:-- {objetoTesla.GetService} Hs" +
                    $"\r\n" +
                    $"\r\n****";
            }
            else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
            {
                EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;

                textBoxForm3.Text = $"**** DATOS SELECCIONADOS: " +
                    $"\r\n" +
                    $"\r\nLARGO:-- {Contexto.ListaObjetos.Count} -- INDICE: {index}" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nAÑO:-- {objetoTesla.GetAnio}" +
                    $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nCOLOR:-- {objetoTesla.GetColor} " +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetHsActual}" +
                    $"\r\nKM-ULTIMO SERVICIO:-- {objetoTesla.GetHsUltimoServicio}" +
                    $"\r\nKM-SIN SERVICIO:-- {objetoTesla.GetHsActual - objetoTesla.GetHsUltimoServicio}" +
                    $"\r\nAUTONOMIA S/CARGA BATERIA:-- {objetoTesla.GetAutonomia} Hs" +
                    $"\r\nCARGA DE BATERIA:-- {objetoTesla.GetTanqueCombustible} % " +
                    $"\r\nREQUERIMIENTO DE SERVICIOS C/:-- {objetoTesla.GetService} Hs" +
                    $"\r\n" +
                    $"\r\n****";
            }

        }

        //- Segun que boton se seleccionara se ejecutara el formulario relacionado, y se cerrara el formulario para luego de la ejecucion volverlo a abrilro y refrescar lista.
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonEliminar.Checked == true)
            {
                textBoxForm3.Text = $"Operacion: Eliminar";
                Form4 formulario = new Form4();
                formulario.Show();
                this.Close();

            }
            else if (radioButtonEscanear.Checked == true)
            {
                textBoxForm3.Text = $"Operacion: Escanear";
                Form5 formulario = new Form5();
                formulario.Show();
                this.Close();
            }
            else if (radioButtonCargar.Checked == true)
            {
                textBoxForm3.Text = $"Operacion: Cargar Bateria - Combustible";
                Form7 formulario = new Form7();
                formulario.Show();
                this.Close();
            }
            else if (radioButtonMovimiento.Checked == true)
            {
                textBoxForm3.Text = $"Operacion: Movimiento Vehicular";
                Form6 formulario = new Form6();
                formulario.Show();
                this.Close();
            }

        }

        //- BOTON SALIR: cierra formulario.
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
