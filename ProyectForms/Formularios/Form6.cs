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
    /// CLASE FORMULARIO 6:
    /// MOVIMIENTO: en este formulario se indicara los datos del objeto junto con la autonomia actual en funcion de la bateria % actual.
    /// Nos permitira indicar un valor de km hs a reacorrer el cual realizara el recorrido y mostrara en pantalla la nueva posicion del vehiculo
    /// luego de realizar dicho recorrido, junto con la nueva autonomia y posicion % de bateria combustible.
    /// Se podrea realizar el recorrido hasta que la autonomia llegue a cero o menor a 20 lo que suceda primero luego de ello solo informara
    /// que requiere una carga previa al recorrido sin poder hacerlo hasta tanto no se recargue la bateria / combustible.
    /// </summary>
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            textBoxInicio.Enabled = false;
            textBoxFinal.Enabled = false;
            buttonRecorrer.Enabled = false;

            Contexto.AutonomiaMin = false;

            int index = Contexto.Indice;
            object objeto = Contexto.ListaObjetos[index];

            if (Contexto.ListaObjetos[index] is TeslaModeloX)
            {
                TeslaModeloX objetoTesla = (TeslaModeloX)objeto;

                textBoxInicio.Text = $"**** SITUACION INICIAL DEL VEHICULO **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nAUTONOMIA de -- {objetoTesla.GetAutonomia} KMS con una carga del {objetoTesla.GetCarga} % en la BATERIA" +
                    $"\r\n";

                Contexto.DatoKmHs = objetoTesla.GetAutonomia;
                ControlMin();
            }
            else if (Contexto.ListaObjetos[index] is TeslaModeloS)
            {
                TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                textBoxInicio.Text = $"**** SITUACION INICIAL DEL VEHICULO **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nAUTONOMIA de -- {objetoTesla.GetAutonomia} KMS con una carga del {objetoTesla.GetCarga} % en la BATERIA" +
                    $"\r\n";

                Contexto.DatoKmHs = objetoTesla.GetAutonomia;
                ControlMin();
            }
            else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
            {
                TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;

                textBoxInicio.Text = $"**** SITUACION INICIAL DEL VEHICULO **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nAUTONOMIA de -- {objetoTesla.GetAutonomia} KMS con una carga del {objetoTesla.GetCarga} % en la BATERIA" +
                    $"\r\n";

                Contexto.DatoKmHs = objetoTesla.GetAutonomia;
                ControlMin();
            }
            else if (Contexto.ListaObjetos[index] is EspaceStarship)
            {
                EspaceStarship objetoTesla = (EspaceStarship)objeto;

                textBoxInicio.Text = $"**** SITUACION INICIAL DEL VEHICULO **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nHS-ACTUAL:-- {objetoTesla.GetHsActual}" +
                    $"\r\nAUTONOMIA de -- {objetoTesla.GetAutonomia} Hs con una carga del {objetoTesla.GetTanqueCombustible} % en el TANQUE DE COMBUSTIBLE" +
                    $"\r\n";

                Contexto.DatoKmHs = objetoTesla.GetAutonomia;
                ControlMin();
            }
            else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
            {
                EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;

                textBoxInicio.Text = $"**** SITUACION INICIAL DEL VEHICULO **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nHS-ACTUAL:-- {objetoTesla.GetHsActual}" +
                    $"\r\nAUTONOMIA de -- {objetoTesla.GetAutonomia} Hs con una carga del {objetoTesla.GetTanqueCombustible} % en el TANQUE DE COMBUSTIBLE" +
                    $"\r\n";

                Contexto.DatoKmHs = objetoTesla.GetAutonomia;
                ControlMin();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int index = Contexto.Indice;
            object objeto = Contexto.ListaObjetos[index];

            if (Contexto.ListaObjetos[index] is TeslaModeloX)
            {
                TeslaModeloX objetoTesla = (TeslaModeloX)objeto;

                objetoTesla.conducir(int.Parse(textBoxKmHsRecorrer.Text));

                textBoxFinal.Text = $"**** SITUACION DEL VEHICULO AL FINALIZAR EL RECORRIDO **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nAUTONOMIA de -- {objetoTesla.GetAutonomia} KMS con una carga del {objetoTesla.GetCarga} % en la BATERIA" +
                    $"\r\n";

                Contexto.DatoKmHs = objetoTesla.GetAutonomia;
                ControlMin();

            }
            else if (Contexto.ListaObjetos[index] is TeslaModeloS)
            {
                TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                objetoTesla.conducir(int.Parse(textBoxKmHsRecorrer.Text));

                textBoxFinal.Text = $"**** SITUACION DEL VEHICULO AL FINALIZAR EL RECORRIDO **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nAUTONOMIA de -- {objetoTesla.GetAutonomia} KMS con una carga del {objetoTesla.GetCarga} % en la BATERIA" +
                    $"\r\n";

                Contexto.DatoKmHs = objetoTesla.GetAutonomia;
                ControlMin();
            }
            else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
            {
                TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;

                objetoTesla.conducir(int.Parse(textBoxKmHsRecorrer.Text));

                textBoxFinal.Text = $"**** SITUACION DEL VEHICULO AL FINALIZAR EL RECORRIDO **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetKmActual}" +
                    $"\r\nAUTONOMIA de -- {objetoTesla.GetAutonomia} KMS con una carga del {objetoTesla.GetCarga} % en la BATERIA" +
                    $"\r\n";

                Contexto.DatoKmHs = objetoTesla.GetAutonomia;
                ControlMin();
            }
            else if (Contexto.ListaObjetos[index] is EspaceStarship)
            {
                EspaceStarship objetoTesla = (EspaceStarship)objeto;

                objetoTesla.recorrido(int.Parse(textBoxKmHsRecorrer.Text));

                textBoxFinal.Text = $"**** SITUACION DEL VEHICULO AL FINALIZAR EL RECORRIDO **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetHsActual}" +
                    $"\r\nAUTONOMIA de -- {objetoTesla.GetAutonomia} KMS con una carga del {objetoTesla.GetTanqueCombustible} % en el TANQUE DE COMBUSTIBLE" +
                    $"\r\n";

                Contexto.DatoKmHs = objetoTesla.GetAutonomia;
                ControlMin();
            }
            else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
            {
                EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;

                objetoTesla.recorrido(int.Parse(textBoxKmHsRecorrer.Text));

                textBoxFinal.Text = $"**** SITUACION DEL VEHICULO AL FINALIZAR EL RECORRIDO **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nKM-ACTUAL:-- {objetoTesla.GetHsActual}" +
                    $"\r\nAUTONOMIA de -- {objetoTesla.GetAutonomia} KMS con una carga del {objetoTesla.GetTanqueCombustible} % en el TANQUE DE COMBUSTIBLE" +
                    $"\r\n";

                Contexto.DatoKmHs = objetoTesla.GetAutonomia;
                ControlMin();
            }
        }

        private void textBoxKmHsRecorrer_TextChanged(object sender, EventArgs e)
        {
            int numero;
            string texto = textBoxKmHsRecorrer.Text;
            bool esNumerico = int.TryParse(texto, out numero);

            if (esNumerico == true)
            {
                if (int.Parse(texto) > (Contexto.DatoKmHs - 1) || int.Parse(texto) < 0)
                {
                    labelKmHsRecorrer.Text = $"Valores debe ser menor que {Contexto.DatoKmHs} km-hs";
                    labelKmHsRecorrer.ForeColor = Color.Red;
                    ControlOK();
                }
                else
                {
                    labelKmHsRecorrer.Text = ".OK";
                    labelKmHsRecorrer.ForeColor = Color.Black;
                    ControlOK();
                }

            }

            if (esNumerico == false)
            {
                labelKmHsRecorrer.Text = "Error: Requiere Numerico Valido";
                labelKmHsRecorrer.ForeColor = Color.Red;
                ControlOK();
            }
            if (string.IsNullOrEmpty(texto))
            {
                labelKmHsRecorrer.Text = "* Dato Obligatorio";
                labelKmHsRecorrer.ForeColor = Color.Black;
                ControlOK();
            }
        }

        private void ControlOK()
        {
            if (labelKmHsRecorrer.Text == ".OK")
            {
                buttonRecorrer.Enabled = true;
            }
            else
            {
                buttonRecorrer.Enabled = false;
            }
        }

        private void ControlMin()
        {
            if (Contexto.AutonomiaMin == true)
            {
                textBoxFinal.Text = $"**** SU AUTONOMIA ES MENOR A 20 KS-HS, SE RECOMIENDA REALIZAR UNA CARGA DE COMBUSTIBLE / BATERIA PREVIO A REALIZAR UN RECORRIDO. **** ";
                buttonRecorrer.Enabled = false;
                textBoxKmHsRecorrer.Enabled = false;

            }
            if (Contexto.AutonomiaMin == false)
            {
                buttonRecorrer.Enabled = true;
            }
        }

        private void buttonFinRecorrido_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
