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

namespace ProyectForms.Formularios
{
    /// <summary>
    /// CLASE FORMULARIO 7:
    /// CARGA BATERIA: en este formulario se mostraran los datos del objeto y relacionados a la autonomia antes de la carga y luego de la rcarga
    /// luego de realizar la carga los valores se reestablecen a sus limites 100% y autonomia al maximo permitiendo poder volver a realizar
    /// recorridos con el objeto.
    /// </summary>
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            textBoxCargas.Enabled = false;

            int index = Contexto.Indice;
            object objeto = Contexto.ListaObjetos[index];

            if (Contexto.ListaObjetos[index] is TeslaModeloX)
            {
                TeslaModeloX objetoTesla = (TeslaModeloX)objeto;

                textBoxCargas.Text = $"**** ESTADO DE BATERIA **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nAUTONOMIA ACTUAL del Vehiculo: -- {objetoTesla.GetAutonomia} KMS " +
                    $"\r\nCARGA ACTUAL DE LA BATERIA: -- {objetoTesla.GetCarga} %" +
                    $"\r\n";

            }
            else if (Contexto.ListaObjetos[index] is TeslaModeloS)
            {
                TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                textBoxCargas.Text = $"**** ESTADO DE BATERIA **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nAUTONOMIA ACTUAL del Vehiculo: -- {objetoTesla.GetAutonomia} KMS " +
                    $"\r\nCARGA ACTUAL DE LA BATERIA: -- {objetoTesla.GetCarga} %" +
                    $"\r\n";

            }
            else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
            {
                TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;

                textBoxCargas.Text = $"**** ESTADO DE BATERIA **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nAUTONOMIA ACTUAL del Vehiculo: -- {objetoTesla.GetAutonomia} KMS " +
                    $"\r\nCARGA ACTUAL DE LA BATERIA: -- {objetoTesla.GetCarga} %" +
                    $"\r\n";

            }
            else if (Contexto.ListaObjetos[index] is EspaceStarship)
            {
                EspaceStarship objetoTesla = (EspaceStarship)objeto;
                
                textBoxCargas.Text = $"**** ESTADO DE COMBUSTIBLE **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nAUTONOMIA ACTUAL del Vehiculo: -- {objetoTesla.GetAutonomia} KMS " +
                    $"\r\nCARGA ACTUAL DE COMBUSTIBLE: -- {objetoTesla.GetTanqueCombustible} %" +
                    $"\r\n";

            }
            else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
            {
                EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;

                textBoxCargas.Text = $"**** ESTADO DE COMBUSTIBLE **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nAUTONOMIA ACTUAL del Vehiculo: -- {objetoTesla.GetAutonomia} KMS " +
                    $"\r\nCARGA ACTUAL DE COMBUSTIBLE: -- {objetoTesla.GetTanqueCombustible} %" +
                    $"\r\n";

            }
        }

        private void buttonFinaCarga_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = Contexto.Indice;
            object objeto = Contexto.ListaObjetos[index];

            if (Contexto.ListaObjetos[index] is TeslaModeloX)
            {
                TeslaModeloX objetoTesla = (TeslaModeloX)objeto;
                objetoTesla.cargarBateria();
                textBoxCargas.Text = $"**** SE REALIZO LA CARGA DE LA BATERIA **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nAUTONOMIA ACTUAL del Vehiculo: -- {objetoTesla.GetAutonomia} KMS " +
                    $"\r\nCARGA ACTUAL DE LA BATERIA: -- {objetoTesla.GetCarga} %" +
                    $"\r\n";

            }
            else if (Contexto.ListaObjetos[index] is TeslaModeloS)
            {
                TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                objetoTesla.cargarBateria();
                textBoxCargas.Text = $"**** SE REALIZO LA CARGA DE LA BATERIA **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nAUTONOMIA ACTUAL del Vehiculo: -- {objetoTesla.GetAutonomia} KMS " +
                    $"\r\nCARGA ACTUAL DE LA BATERIA: -- {objetoTesla.GetCarga} %" +
                    $"\r\n";

            }
            else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
            {
                TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;

                objetoTesla.cargarBateria();
                textBoxCargas.Text = $"**** SE REALIZO LA CARGA DE LA BATERIA **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}" +
                    $"\r\nAUTONOMIA ACTUAL del Vehiculo: -- {objetoTesla.GetAutonomia} KMS " +
                    $"\r\nCARGA ACTUAL DE LA BATERIA: -- {objetoTesla.GetCarga} %" +
                    $"\r\n";

            }
            else if (Contexto.ListaObjetos[index] is EspaceStarship)
            {
                EspaceStarship objetoTesla = (EspaceStarship)objeto;

                objetoTesla.cargarTanqueCombustible();
                textBoxCargas.Text = $"**** SE REALIZO LA CARGA DE COMBUSTIBLE **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nAUTONOMIA ACTUAL del Vehiculo: -- {objetoTesla.GetAutonomia} KMS " +
                    $"\r\nCARGA ACTUAL DE LA BATERIA: -- {objetoTesla.GetTanqueCombustible} %" +
                    $"\r\n";

            }
            else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
            {
                EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;

                objetoTesla.cargarTanqueCombustible();
                textBoxCargas.Text = $"**** SE REALIZO LA CARGA DE COMBUSTIBLE **** " +
                    $"\r\n" +
                    $"\r\nN° IDENTIFICADOR:-- {objetoTesla.GetNId}" +
                    $"\r\nN° MODELO:-- {objetoTesla.GetModelo}" +
                    $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}" +
                    $"\r\nAUTONOMIA ACTUAL del Vehiculo: -- {objetoTesla.GetAutonomia} KMS " +
                    $"\r\nCARGA ACTUAL DE LA BATERIA: -- {objetoTesla.GetTanqueCombustible} %" +
                    $"\r\n";


            }
        }
    }
}
