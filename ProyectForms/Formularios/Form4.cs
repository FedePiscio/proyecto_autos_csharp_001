using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectForms.ClasesContexto;
using Proyecto.ClasesTesla;
using ProyectForms.ClasesTesla;
using ProyectForms.ClaseEspace;


namespace ProyectForms.Formularios
{
    /// <summary>
    /// CLASE FORMULARIO 4:
    /// Este formulario lo que permitira es observa los datos seleccionados para eliminar permitiendole al usuario observa y controlar que los datos
    /// que selecciono sean los correctos antes de realizar la eliminacion del objeto de la lista del contexto, con las 2 opciones cancelar y/o eliminar.
    /// De realizarse la eliminacion se ejecuta el procedimiento de indentificacion del objeto y eliminacion de la lista del contexto para luego
    /// volver a ejecutar el formulario 3 con la nueva visualizacion de la lista sin el objeto eliminado, para poder seguir operando.
    /// </summary>
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
            textBox1.Enabled = false;

            int index = Contexto.Indice;
            object objeto = Contexto.ListaObjetos[index];

            if (Contexto.ListaObjetos[index] is TeslaModeloX)
            {
                TeslaModeloX objetoTesla = (TeslaModeloX)objeto;

                textBox1.Text = $"**** USTED ESTA POR REALIZAR UNA OPERACION DE ELIMINACION DE LOS DATOS QUE A CONTINUACION SE DETALLAN: " +
                    $"\r\n" +
                    $"\r\nLARGO:-- {Contexto.ListaObjetos.Count} -- INDICE: {index}" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nAÑO:-- {objetoTesla.GetAnio}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nCOLOR:-- {objetoTesla.GetColor} " +
                    $"\r\n" +
                    $"\r\n**** CONTROLE QUE LA INFORMACION A ELIMINAR SEA LA CORRECTA";

            }
            else if (Contexto.ListaObjetos[index] is TeslaModeloS)
            {
                TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                textBox1.Text = $"**** USTED ESTA POR REALIZAR UNA OPERACION DE ELIMINACION DE LOS DATOS QUE A CONTINUACION SE DETALLAN: " +
                    $"\r\n" +
                    $"\r\nLARGO:-- {Contexto.ListaObjetos.Count} -- INDICE: {index}" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nAÑO:-- {objetoTesla.GetAnio}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nCOLOR:-- {objetoTesla.GetColor} " +
                    $"\r\n" +
                    $"\r\n**** CONTROLE QUE LA INFORMACION A ELIMINAR SEA LA CORRECTA";
            }
            else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
            {
                TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;

                textBox1.Text = $"**** USTED ESTA POR REALIZAR UNA OPERACION DE ELIMINACION DE LOS DATOS QUE A CONTINUACION SE DETALLAN: " +
                    $"\r\n" +
                    $"\r\nLARGO:-- {Contexto.ListaObjetos.Count} -- INDICE: {index}" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nAÑO:-- {objetoTesla.GetAnio}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nCOLOR:-- {objetoTesla.GetColor} " +
                    $"\r\n" +
                    $"\r\n**** CONTROLE QUE LA INFORMACION A ELIMINAR SEA LA CORRECTA";
            }
            else if (Contexto.ListaObjetos[index] is EspaceStarship)
            {
                EspaceStarship objetoTesla = (EspaceStarship)objeto;

                textBox1.Text = $"**** USTED ESTA POR REALIZAR UNA OPERACION DE ELIMINACION DE LOS DATOS QUE A CONTINUACION SE DETALLAN: " +
                    $"\r\n" +
                    $"\r\nLARGO:-- {Contexto.ListaObjetos.Count} -- INDICE: {index}" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nAÑO:-- {objetoTesla.GetAnio}" +
                    $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nHS-ACTUAL:-- {objetoTesla.GetHsActual}" +
                    $"\r\nCOLOR:-- {objetoTesla.GetColor} " +
                    $"\r\n" +
                    $"\r\n**** CONTROLE QUE LA INFORMACION A ELIMINAR SEA LA CORRECTA";
            }
            else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
            {
                EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;

                textBox1.Text = $"**** USTED ESTA POR REALIZAR UNA OPERACION DE ELIMINACION DE LOS DATOS QUE A CONTINUACION SE DETALLAN: " +
                    $"\r\n" +
                    $"\r\nLARGO:-- {Contexto.ListaObjetos.Count} -- INDICE: {index}" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nAÑO:-- {objetoTesla.GetAnio}" +
                    $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nHS-ACTUAL:-- {objetoTesla.GetHsActual}" +
                    $"\r\nCOLOR:-- {objetoTesla.GetColor} " +
                    $"\r\n" +
                    $"\r\n**** CONTROLE QUE LA INFORMACION A ELIMINAR SEA LA CORRECTA";
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Contexto.IndiceEliminar = Contexto.Indice;
            Contexto.ListaObjetos.RemoveAt(Contexto.IndiceEliminar);
            Form3 formulario3 = new Form3();
            formulario3.Show();
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3();
            formulario3.Show();
            this.Close();
        }
    }
}
