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
using ProyectForms.Formularios;
using System.Reflection;
using Proyecto.ClaseEscaner;
using System.Security.Policy;

namespace ProyectForms.Formularios
{
    /// <summary>
    /// CLASE FORMULARIO 5:
    /// Este formulario sera el que nos permitira realizar uno de los procesos mas complejos del programa, seleccionado el objeto con el cual vamos a realizar
    /// el escaneo nos permitira indicar un kilometraje o horas del ultimo servicio que sera el parametro a tomar para compararlo con el kilometraje horas actual
    /// para que el escaneo indique que controes corresponderia realizar, de no introducir datos se inicializara el parametro en 0 y posterior al servicio se redefinira
    /// el valor como ultimo servicio realizado.
    /// ESCANEO: una ves que se ejecuta el escaneo se visualizara en pantalla todos los datos relativos al objeto existentes en el sistema y al final indicara que controles
    /// requiere el objeto, de no requerir controles sera indicado en pantalla, y permitira unicamente la finalizacion del proces, de requerirse controles de servicios
    /// se habilitara la opciones realizar servicios.-
    /// REALIZAR SERVICIOS: al realizar servicios, el sistema lo que hace es ejecutar los metodos que indicaran que todos los servicios se realizaron y ya no requiere servicios
    /// redefiniendo el kilometraje horas del ultimo servicio, y informando todos los datos en pantalla, dando la unica posibilidad ded finalizar el procedimiento.
    /// De volver a realizarse un escaneo al mismo objeto el mismo se definira como que no requiere servicios al coincidir km-hs ultimos servicio = km hs Actual.
    /// </summary>
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBoxEscaner.Enabled = false;
            textBoxEscanerService.Enabled = false;

            buttoneEscanear.Enabled = false;
            buttonRealizarServ.Enabled = false;
            buttonFinalizar.Enabled = false;

            int index = Contexto.Indice;
            object objeto = Contexto.ListaObjetos[index];


            if (Contexto.ListaObjetos[index] is TeslaModeloX)
            {
                TeslaModeloX objetoTesla = (TeslaModeloX)objeto;
                textBoxKmHsServ.Text = $"{objetoTesla.GetKmUltimoServicio}";

            }
            else if (Contexto.ListaObjetos[index] is TeslaModeloS)
            {
                TeslaModeloS objetoTesla = (TeslaModeloS)objeto;
                textBoxKmHsServ.Text = $"{objetoTesla.GetKmUltimoServicio}";
            }
            else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
            {
                TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;
                textBoxKmHsServ.Text = $"{objetoTesla.GetKmUltimoServicio}";
            }
            else if (Contexto.ListaObjetos[index] is EspaceStarship)
            {
                EspaceStarship objetoTesla = (EspaceStarship)objeto;
                textBoxKmHsServ.Text = $"{objetoTesla.GetHsUltimoServicio}";
            }
            else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
            {
                EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;
                textBoxKmHsServ.Text = $"{objetoTesla.GetHsUltimoServicio}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Escaner escaneo = new Escaner(Contexto.DatoKmHs, Contexto.ListaObjetos[Contexto.Indice]);

                escaneo.escanearSistemas();

                buttonRealizarServ.Enabled = false;
                buttonFinalizar.Enabled = true;

                int index = Contexto.Indice;
                object objeto = Contexto.ListaObjetos[index];

                if (Contexto.ListaObjetos[index] is TeslaModeloX)
                {
                    TeslaModeloX objetoTesla = (TeslaModeloX)objeto;
                    objetoTesla.SetKmUltimoServicio = Contexto.DatoKmHs;
                    textBoxEscanerService.Text =
                            $"\r\n************************************************************************" +
                            $"\r\nSE REALIZARON LOS SERVICIOS Y REQUERIMIENTOS SOLICITADOS  " +
                            $"\r\n************************************************************************" +
                            $"\r\n" +
                            $"\r\n*** DATOS DEL VEHICULO ***" +
                            $"\r\n" +
                            $"\r\nN° IDENTIFICACION:-- {objetoTesla.GetNId}-" +
                            $"\r\nMODELO:-- {objetoTesla.GetModelo}-" +
                            $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}-" +
                            $"\r\nAÑO FABRICACION:-- {objetoTesla.GetAnio}-" +
                            $"\r\nKM-ACTUAL: {objetoTesla.GetKmActual} KMS-" +
                            $"\r\nKM-ULTIMO SERVICIO:{objetoTesla.GetKmUltimoServicio} KMS-" +
                            $"\r\nKM-SIN SERVICIO: {objetoTesla.GetKmActual - Contexto.DatoKmHs} KMS-" +
                            $"\r\nCOLOR: {objetoTesla.GetColor}-" +
                            $"\r\n" +
                            $"\r\n*** DATOS TECNICOS DEL VEHICULO ***" +
                            $"\r\n" +
                            $"\r\nCANT. ASIENTOS: {objetoTesla.GetAsientos}-" +
                            $"\r\nAUTONOMIA CON EL {objetoTesla.GetCarga} % DE LABATERIA REPRESENTA: {objetoTesla.GetAutonomia} KMS-" +
                            $"\r\nREQUERIMIENTO DE SERIVIO CADA : {objetoTesla.GetService} KMS-" +
                            $"\r\nCARGA ACTUAL DE LA BATERIAS: {objetoTesla.GetCarga} % -" +
                            $"\r\n" +
                            $"\r\n*** REQUERIMIENTOS: RESULTADOS DEL ESCANEO ***" +
                            $"\r\n" +
                            $"\r\nSITUACION: SIN REQUERIMIENTO: {Contexto.SinRequerimientos}-" +
                            $"\r\nREQUIERE CONTROL DE CINTURONES: {Contexto.ControlCinturones}-" +
                            $"\r\nREQUIERE CONTROL DE BATERIAS: {Contexto.ControlBateria}-" +
                            $"\r\nREQUIERE CONTROL DE PROPULSION: {Contexto.ControlPropulsion}-" +
                            $"\r\nREQUIERE CONTROL DE TRACCION: {Contexto.ControlTraccion}-" +
                            $"\r\nREQUIERE CONTROL DE MOTOR: {Contexto.ControlMotor}-" +
                            $"\r\nREQUIERE CONTROL DE NAVEGACION: {Contexto.ControlNavegacion}";

                }
                else if (Contexto.ListaObjetos[index] is TeslaModeloS)
                {
                    TeslaModeloS objetoTesla = (TeslaModeloS)objeto;
                    objetoTesla.SetKmUltimoServicio = Contexto.DatoKmHs;
                    textBoxEscanerService.Text =
                            $"\r\n************************************************************************" +
                            $"\r\nSE REALIZARON LOS SERVICIOS Y REQUERIMIENTOS SOLICITADOS  " +
                            $"\r\n************************************************************************" +
                            $"\r\n" +
                            $"\r\n*** DATOS DEL VEHICULO ***" +
                            $"\r\n" +
                            $"\r\nN° IDENTIFICACION:-- {objetoTesla.GetNId}-" +
                            $"\r\nMODELO:-- {objetoTesla.GetModelo}-" +
                            $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}-" +
                            $"\r\nAÑO FABRICACION:-- {objetoTesla.GetAnio}-" +
                            $"\r\nKM-ACTUAL: {objetoTesla.GetKmActual} KMS-" +
                            $"\r\nKM-ULTIMO SERVICIO:{objetoTesla.GetKmUltimoServicio} KMS-" +
                            $"\r\nKM-SIN SERVICIO: {objetoTesla.GetKmActual - Contexto.DatoKmHs} KMS-" +
                            $"\r\nCOLOR: {objetoTesla.GetColor}-" +
                            $"\r\n" +
                            $"\r\n*** DATOS TECNICOS DEL VEHICULO ***" +
                            $"\r\n" +
                            $"\r\nCANT. ASIENTOS: {objetoTesla.GetAsientos}-" +
                            $"\r\nAUTONOMIA CON EL {objetoTesla.GetCarga} % DE LABATERIA REPRESENTA: {objetoTesla.GetAutonomia} KMS-" +
                            $"\r\nREQUERIMIENTO DE SERIVIO CADA : {objetoTesla.GetService} KMS-" +
                            $"\r\nCARGA ACTUAL DE LA BATERIAS: {objetoTesla.GetCarga} % -" +
                            $"\r\n" +
                            $"\r\n*** REQUERIMIENTOS: RESULTADOS DEL ESCANEO ***" +
                            $"\r\n" +
                            $"\r\nSITUACION: SIN REQUERIMIENTO: {Contexto.SinRequerimientos}-" +
                            $"\r\nREQUIERE CONTROL DE CINTURONES: {Contexto.ControlCinturones}-" +
                            $"\r\nREQUIERE CONTROL DE BATERIAS: {Contexto.ControlBateria}-" +
                            $"\r\nREQUIERE CONTROL DE PROPULSION: {Contexto.ControlPropulsion}-" +
                            $"\r\nREQUIERE CONTROL DE TRACCION: {Contexto.ControlTraccion}-" +
                            $"\r\nREQUIERE CONTROL DE MOTOR: {Contexto.ControlMotor}-" +
                            $"\r\nREQUIERE CONTROL DE NAVEGACION: {Contexto.ControlNavegacion}";

                }

                else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
                {
                    TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;
                    objetoTesla.SetKmUltimoServicio = Contexto.DatoKmHs;
                    textBoxEscanerService.Text =
                            $"\r\n************************************************************************" +
                            $"\r\nSE REALIZARON LOS SERVICIOS Y REQUERIMIENTOS SOLICITADOS  " +
                            $"\r\n************************************************************************" +
                            $"\r\n" +
                            $"\r\n*** DATOS DEL VEHICULO ***" +
                            $"\r\n" +
                            $"\r\nN° IDENTIFICACION:-- {objetoTesla.GetNId}-" +
                            $"\r\nMODELO:-- {objetoTesla.GetModelo}-" +
                            $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}-" +
                            $"\r\nAÑO FABRICACION:-- {objetoTesla.GetAnio}-" +
                            $"\r\nKM-ACTUAL: {objetoTesla.GetKmActual} KMS-" +
                            $"\r\nKM-ULTIMO SERVICIO:{objetoTesla.GetKmUltimoServicio} KMS-" +
                            $"\r\nKM-SIN SERVICIO: {objetoTesla.GetKmActual - Contexto.DatoKmHs} KMS-" +
                            $"\r\nCOLOR: {objetoTesla.GetColor}-" +
                            $"\r\n" +
                            $"\r\n*** DATOS TECNICOS DEL VEHICULO ***" +
                            $"\r\n" +
                            $"\r\nCANT. ASIENTOS: {objetoTesla.GetAsientos}-" +
                            $"\r\nAUTONOMIA CON EL {objetoTesla.GetCarga} % DE LABATERIA REPRESENTA: {objetoTesla.GetAutonomia} KMS-" +
                            $"\r\nREQUERIMIENTO DE SERIVIO CADA : {objetoTesla.GetService} KMS-" +
                            $"\r\nCARGA ACTUAL DE LA BATERIAS: {objetoTesla.GetCarga} % -" +
                            $"\r\n" +
                            $"\r\n*** REQUERIMIENTOS: RESULTADOS DEL ESCANEO ***" +
                            $"\r\n" +
                            $"\r\nSITUACION: SIN REQUERIMIENTO: {Contexto.SinRequerimientos}-" +
                            $"\r\nREQUIERE CONTROL DE CINTURONES: {Contexto.ControlCinturones}-" +
                            $"\r\nREQUIERE CONTROL DE BATERIAS: {Contexto.ControlBateria}-" +
                            $"\r\nREQUIERE CONTROL DE PROPULSION: {Contexto.ControlPropulsion}-" +
                            $"\r\nREQUIERE CONTROL DE TRACCION: {Contexto.ControlTraccion}-" +
                            $"\r\nREQUIERE CONTROL DE MOTOR: {Contexto.ControlMotor}-" +
                            $"\r\nREQUIERE CONTROL DE NAVEGACION: {Contexto.ControlNavegacion}";

                }

                else if (Contexto.ListaObjetos[index] is EspaceStarship)
                {
                    EspaceStarship objetoTesla = (EspaceStarship)objeto;
                    objetoTesla.SetHsUltimoServicio = Contexto.DatoKmHs;
                    textBoxEscanerService.Text =
                            $"\r\n************************************************************************" +
                            $"\r\nSE REALIZARON LOS SERVICIOS Y REQUERIMIENTOS SOLICITADOS  " +
                            $"\r\n************************************************************************" +
                            $"\r\n" +
                            $"\r\n*** DATOS DEL VEHICULO ***" +
                            $"\r\n" +
                            $"\r\nN° IDENTIFICACION:-- {objetoTesla.GetNId}-" +
                            $"\r\nMODELO:-- {objetoTesla.GetModelo}-" +
                            $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}-" +
                            $"\r\nAÑO FABRICACION:-- {objetoTesla.GetAnio}-" +
                            $"\r\nHS-ACTUAL: {objetoTesla.GetHsActual} HS-" +
                            $"\r\nHS-ULTIMO SERVICIO:{objetoTesla.GetHsUltimoServicio} HS-" +
                            $"\r\nHS-SIN SERVICIO: {objetoTesla.GetHsActual - Contexto.DatoKmHs} HS-" +
                            $"\r\nCOLOR: {objetoTesla.GetColor}-" +
                            $"\r\n" +
                            $"\r\n*** DATOS TECNICOS DEL VEHICULO ***" +
                            $"\r\n" +
                            $"\r\nAUTONOMIA CON EL {objetoTesla.GetTanqueCombustible} % DE COMBUSTIBLE: {objetoTesla.GetAutonomia} HS-" +
                            $"\r\nREQUERIMIENTO DE SERIVIO CADA : {objetoTesla.GetService} HS-" +
                            $"\r\nCARGA ACTUAL DE LA BATERIAS: {objetoTesla.GetTanqueCombustible} % -" +
                            $"\r\n" +
                            $"\r\n*** REQUERIMIENTOS: RESULTADOS DEL ESCANEO ***" +
                            $"\r\n" +
                            $"\r\nSITUACION: SIN REQUERIMIENTO: {Contexto.SinRequerimientos}-" +
                            $"\r\nREQUIERE CONTROL DE CINTURONES: {Contexto.ControlCinturones}-" +
                            $"\r\nREQUIERE CONTROL DE BATERIAS: {Contexto.ControlBateria}-" +
                            $"\r\nREQUIERE CONTROL DE PROPULSION: {Contexto.ControlPropulsion}-" +
                            $"\r\nREQUIERE CONTROL DE TRACCION: {Contexto.ControlTraccion}-" +
                            $"\r\nREQUIERE CONTROL DE MOTOR: {Contexto.ControlMotor}-" +
                            $"\r\nREQUIERE CONTROL DE NAVEGACION: {Contexto.ControlNavegacion}";
                }
                else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
                {
                    EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;
                    objetoTesla.SetHsUltimoServicio = Contexto.DatoKmHs;
                    textBoxEscanerService.Text =
                            $"\r\n************************************************************************" +
                            $"\r\nSE REALIZARON LOS SERVICIOS Y REQUERIMIENTOS SOLICITADOS  " +
                            $"\r\n************************************************************************" +
                            $"\r\n" +
                            $"\r\n*** DATOS DEL VEHICULO ***" +
                            $"\r\n" +
                            $"\r\nN° IDENTIFICACION:-- {objetoTesla.GetNId}-" +
                            $"\r\nMODELO:-- {objetoTesla.GetModelo}-" +
                            $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}-" +
                            $"\r\nAÑO FABRICACION:-- {objetoTesla.GetAnio}-" +
                            $"\r\nHS-ACTUAL: {objetoTesla.GetHsActual} HS-" +
                            $"\r\nHS-ULTIMO SERVICIO:{objetoTesla.GetHsUltimoServicio} HS-" +
                            $"\r\nHS-SIN SERVICIO: {objetoTesla.GetHsActual - Contexto.DatoKmHs} HS-" +
                            $"\r\nCOLOR: {objetoTesla.GetColor}-" +
                            $"\r\n" +
                            $"\r\n*** DATOS TECNICOS DEL VEHICULO ***" +
                            $"\r\n" +
                            $"\r\nAUTONOMIA CON EL {objetoTesla.GetTanqueCombustible} % DE COMBUSTIBLE: {objetoTesla.GetAutonomia} HS-" +
                            $"\r\nREQUERIMIENTO DE SERIVIO CADA : {objetoTesla.GetService} HS-" +
                            $"\r\nCARGA ACTUAL DE LA BATERIAS: {objetoTesla.GetTanqueCombustible} % -" +
                            $"\r\n" +
                            $"\r\n*** REQUERIMIENTOS: RESULTADOS DEL ESCANEO ***" +
                            $"\r\n" +
                            $"\r\nSITUACION: SIN REQUERIMIENTO: {Contexto.SinRequerimientos}-" +
                            $"\r\nREQUIERE CONTROL DE CINTURONES: {Contexto.ControlCinturones}-" +
                            $"\r\nREQUIERE CONTROL DE BATERIAS: {Contexto.ControlBateria}-" +
                            $"\r\nREQUIERE CONTROL DE PROPULSION: {Contexto.ControlPropulsion}-" +
                            $"\r\nREQUIERE CONTROL DE TRACCION: {Contexto.ControlTraccion}-" +
                            $"\r\nREQUIERE CONTROL DE MOTOR: {Contexto.ControlMotor}-" +
                            $"\r\nREQUIERE CONTROL DE NAVEGACION: {Contexto.ControlNavegacion}";
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numero;
            string texto = textBoxKmHsServ.Text;
            bool esNumerico = int.TryParse(texto, out numero);

            int index = Contexto.Indice;
            object objeto = Contexto.ListaObjetos[index];


            if (Contexto.ListaObjetos[index] is TeslaModeloX)
            {
                TeslaModeloX objetoTesla = (TeslaModeloX)objeto;
                Contexto.DatoKmHs = objetoTesla.GetKmActual;
                Contexto.DatoKmHsUltimoServ = objetoTesla.GetKmUltimoServicio;

            }
            else if (Contexto.ListaObjetos[index] is TeslaModeloS)
            {
                TeslaModeloS objetoTesla = (TeslaModeloS)objeto;
                Contexto.DatoKmHs = objetoTesla.GetKmActual;
                Contexto.DatoKmHsUltimoServ = objetoTesla.GetKmUltimoServicio;

            }
            else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
            {
                TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;
                Contexto.DatoKmHs = objetoTesla.GetKmActual;
                Contexto.DatoKmHsUltimoServ = objetoTesla.GetKmUltimoServicio;

            }
            else if (Contexto.ListaObjetos[index] is EspaceStarship)
            {
                EspaceStarship objetoTesla = (EspaceStarship)objeto;
                Contexto.DatoKmHs = objetoTesla.GetHsActual;
                Contexto.DatoKmHsUltimoServ = objetoTesla.GetHsUltimoServicio;
            }
            else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
            {
                EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;
                Contexto.DatoKmHs = objetoTesla.GetHsActual;
                Contexto.DatoKmHsUltimoServ = objetoTesla.GetHsUltimoServicio;
            }

            // Condicion Logica

            if (esNumerico == true)
            {
                if (int.Parse(texto) > 1000000 || int.Parse(texto) < 0)
                {

                    labelKmHsServ.Text = "Valores entre 0 - 1000000 km-hs";
                    labelKmHsServ.ForeColor = Color.Red;
                    ControlOK();

                }
                else if (int.Parse(texto) > Contexto.DatoKmHs || int.Parse(texto) < Contexto.DatoKmHsUltimoServ)
                {
                    labelKmHsServ.Text = $"Valores: Entre {Contexto.DatoKmHsUltimoServ} y {Contexto.DatoKmHs}";
                    labelKmHsServ.ForeColor = Color.Red;
                    ControlOK();
                }
                else
                {
                    labelKmHsServ.Text = ".OK";
                    labelKmHsServ.ForeColor = Color.Black;
                    ControlOK();
                    Contexto.DatoKmHs = int.Parse(texto);
                }

            }

            if (esNumerico == false)
            {
                labelKmHsServ.Text = "Error: Requiere Numerico Valido";
                labelKmHsServ.ForeColor = Color.Red;
                ControlOK();
            }
            if (string.IsNullOrEmpty(texto))
            {
                labelKmHsServ.Text = "* Dato Obligatorio";
                labelKmHsServ.ForeColor = Color.Black;
                ControlOK();
            }
        }

        private void ControlOK()
        {
            if (labelKmHsServ.Text == ".OK")
            {
                buttoneEscanear.Enabled = true;
            }
            else
            {
                buttoneEscanear.Enabled = false;
            }
        }

        private void buttoneEscanear_Click(object sender, EventArgs e)
        {
            Escaner escaneo = new Escaner(int.Parse(textBoxKmHsServ.Text), Contexto.ListaObjetos[Contexto.Indice]);

            escaneo.escanearSistemas();

            ControlSinRequerimiento();

            int index = Contexto.Indice;
            object objeto = Contexto.ListaObjetos[index];


            if (Contexto.ListaObjetos[index] is TeslaModeloX)
            {
                TeslaModeloX objetoTesla = (TeslaModeloX)objeto;

                textBoxEscaner.Text =
                        $"\r\n*** DATOS DEL VEHICULO ***" +
                        $"\r\n" +
                        $"\r\nN° IDENTIFICACION:-- {objetoTesla.GetNId}-" +
                        $"\r\nMODELO:-- {objetoTesla.GetModelo}-" +
                        $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}-" +
                        $"\r\nAÑO FABRICACION:-- {objetoTesla.GetAnio}-" +
                        $"\r\nKM-ACTUAL: {objetoTesla.GetKmActual} KMS-" +
                        $"\r\nKM-ULTIMO SERVICIO:{Contexto.DatoKmHs} KMS-" +
                        $"\r\nKM-SIN SERVICIO: {objetoTesla.GetKmActual - Contexto.DatoKmHs} KMS-" +
                        $"\r\nCOLOR: {objetoTesla.GetColor}-" +
                        $"\r\n" +
                        $"\r\n*** DATOS TECNICOS DEL VEHICULO ***" +
                        $"\r\n" +
                        $"\r\nCANT. ASIENTOS: {objetoTesla.GetAsientos}-" +
                        $"\r\nAUTONOMIA CON EL {objetoTesla.GetCarga} % DE LABATERIA REPRESENTA: {objetoTesla.GetAutonomia} KMS-" +
                        $"\r\nREQUERIMIENTO DE SERIVIO CADA : {objetoTesla.GetService} KMS-" +
                        $"\r\nCARGA ACTUAL DE LA BATERIAS: {objetoTesla.GetCarga} % -" +
                        $"\r\n" +
                        $"\r\n*** REQUERIMIENTOS: RESULTADOS DEL ESCANEO ***" +
                        $"\r\n" +
                        $"\r\nSITUACION: SIN REQUERIMIENTO: {Contexto.SinRequerimientos}-" +
                        $"\r\nREQUIERE CONTROL DE CINTURONES: {Contexto.ControlCinturones}-" +
                        $"\r\nREQUIERE CONTROL DE BATERIAS: {Contexto.ControlBateria}-" +
                        $"\r\nREQUIERE CONTROL DE PROPULSION: {Contexto.ControlPropulsion}-" +
                        $"\r\nREQUIERE CONTROL DE TRACCION: {Contexto.ControlTraccion}-" +
                        $"\r\nREQUIERE CONTROL DE MOTOR: {Contexto.ControlMotor}-" +
                        $"\r\nREQUIERE CONTROL DE NAVEGACION: {Contexto.ControlNavegacion}";

                Contexto.DatoKmHs = objetoTesla.GetKmActual;
            }
            else if (Contexto.ListaObjetos[index] is TeslaModeloS)
            {
                TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                textBoxEscaner.Text =
                        $"\r\n*** DATOS DEL VEHICULO ***" +
                        $"\r\n" +
                        $"\r\nN° IDENTIFICACION:-- {objetoTesla.GetNId}-" +
                        $"\r\nMODELO:-- {objetoTesla.GetModelo}-" +
                        $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}-" +
                        $"\r\nAÑO FABRICACION:-- {objetoTesla.GetAnio}-" +
                        $"\r\nKM-ACTUAL: {objetoTesla.GetKmActual} KMS-" +
                        $"\r\nKM-ULTIMO SERVICIO:{Contexto.DatoKmHs} KMS-" +
                        $"\r\nKM-SIN SERVICIO: {objetoTesla.GetKmActual - Contexto.DatoKmHs} KMS-" +
                        $"\r\nCOLOR: {objetoTesla.GetColor}-" +
                        $"\r\n" +
                        $"\r\n*** DATOS TECNICOS DEL VEHICULO ***" +
                        $"\r\n" +
                        $"\r\nCANT. ASIENTOS: {objetoTesla.GetAsientos}-" +
                        $"\r\nAUTONOMIA CON EL {objetoTesla.GetCarga} % DE LABATERIA REPRESENTA: {objetoTesla.GetAutonomia} KMS-" +
                        $"\r\nREQUERIMIENTO DE SERIVIO CADA : {objetoTesla.GetService} KMS-" +
                        $"\r\nCARGA ACTUAL DE LA BATERIAS: {objetoTesla.GetCarga} % -" +
                        $"\r\n" +
                        $"\r\n*** REQUERIMIENTOS: RESULTADOS DEL ESCANEO ***" +
                        $"\r\n" +
                        $"\r\nSITUACION: SIN REQUERIMIENTO: {Contexto.SinRequerimientos}-" +
                        $"\r\nREQUIERE CONTROL DE CINTURONES: {Contexto.ControlCinturones}-" +
                        $"\r\nREQUIERE CONTROL DE BATERIAS: {Contexto.ControlBateria}-" +
                        $"\r\nREQUIERE CONTROL DE PROPULSION: {Contexto.ControlPropulsion}-" +
                        $"\r\nREQUIERE CONTROL DE TRACCION: {Contexto.ControlTraccion}-" +
                        $"\r\nREQUIERE CONTROL DE MOTOR: {Contexto.ControlMotor}-" +
                        $"\r\nREQUIERE CONTROL DE NAVEGACION: {Contexto.ControlNavegacion}";

                Contexto.DatoKmHs = objetoTesla.GetKmActual;
            }

            else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
            {
                TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;

                textBoxEscaner.Text =
                        $"\r\n*** DATOS DEL VEHICULO ***" +
                        $"\r\n" +
                        $"\r\nN° IDENTIFICACION:-- {objetoTesla.GetNId}-" +
                        $"\r\nMODELO:-- {objetoTesla.GetModelo}-" +
                        $"\r\nDUEÑO:-- {objetoTesla.GetDuenio}-" +
                        $"\r\nAÑO FABRICACION:-- {objetoTesla.GetAnio}-" +
                        $"\r\nKM-ACTUAL: {objetoTesla.GetKmActual} KMS-" +
                        $"\r\nKM-ULTIMO SERVICIO:{Contexto.DatoKmHs} KMS-" +
                        $"\r\nKM-SIN SERVICIO: {objetoTesla.GetKmActual - Contexto.DatoKmHs} KMS-" +
                        $"\r\nCOLOR: {objetoTesla.GetColor}-" +
                        $"\r\n" +
                        $"\r\n*** DATOS TECNICOS DEL VEHICULO ***" +
                        $"\r\n" +
                        $"\r\nCANT. ASIENTOS: {objetoTesla.GetAsientos}-" +
                        $"\r\nAUTONOMIA CON EL {objetoTesla.GetCarga} % DE LABATERIA REPRESENTA: {objetoTesla.GetAutonomia} KMS-" +
                        $"\r\nREQUERIMIENTO DE SERIVIO CADA : {objetoTesla.GetService} KMS-" +
                        $"\r\nCARGA ACTUAL DE LA BATERIAS: {objetoTesla.GetCarga} % -" +
                        $"\r\n" +
                        $"\r\n*** REQUERIMIENTOS: RESULTADOS DEL ESCANEO ***" +
                        $"\r\n" +
                        $"\r\nSITUACION: SIN REQUERIMIENTO: {Contexto.SinRequerimientos}-" +
                        $"\r\nREQUIERE CONTROL DE CINTURONES: {Contexto.ControlCinturones}-" +
                        $"\r\nREQUIERE CONTROL DE BATERIAS: {Contexto.ControlBateria}-" +
                        $"\r\nREQUIERE CONTROL DE PROPULSION: {Contexto.ControlPropulsion}-" +
                        $"\r\nREQUIERE CONTROL DE TRACCION: {Contexto.ControlTraccion}-" +
                        $"\r\nREQUIERE CONTROL DE MOTOR: {Contexto.ControlMotor}-" +
                        $"\r\nREQUIERE CONTROL DE NAVEGACION: {Contexto.ControlNavegacion}";

                Contexto.DatoKmHs = objetoTesla.GetKmActual;
            }

            else if (Contexto.ListaObjetos[index] is EspaceStarship)
            {
                EspaceStarship objetoTesla = (EspaceStarship)objeto;

                textBoxEscaner.Text =
                        $"\r\n*** DATOS DEL VEHICULO ***" +
                        $"\r\n" +
                        $"\r\nN° IDENTIFICACION:-- {objetoTesla.GetNId}-" +
                        $"\r\nMODELO:-- {objetoTesla.GetModelo}-" +
                        $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}-" +
                        $"\r\nAÑO FABRICACION:-- {objetoTesla.GetAnio}-" +
                        $"\r\nHS-ACTUAL: {objetoTesla.GetHsActual} HS-" +
                        $"\r\nHS-ULTIMO SERVICIO:{Contexto.DatoKmHs} HS-" +
                        $"\r\nHS-SIN SERVICIO: {objetoTesla.GetHsActual - Contexto.DatoKmHs} HS-" +
                        $"\r\nCOLOR: {objetoTesla.GetColor}-" +
                        $"\r\n" +
                        $"\r\n*** DATOS TECNICOS DEL VEHICULO ***" +
                        $"\r\n" +
                        $"\r\nAUTONOMIA CON EL {objetoTesla.GetTanqueCombustible} % DE COMBUSTIBLE: {objetoTesla.GetAutonomia} HS-" +
                        $"\r\nREQUERIMIENTO DE SERIVIO CADA : {objetoTesla.GetService} HS-" +
                        $"\r\nCARGA ACTUAL DE LA BATERIAS: {objetoTesla.GetTanqueCombustible} % -" +
                        $"\r\n" +
                        $"\r\n*** REQUERIMIENTOS: RESULTADOS DEL ESCANEO ***" +
                        $"\r\n" +
                        $"\r\nSITUACION: SIN REQUERIMIENTO: {Contexto.SinRequerimientos}-" +
                        $"\r\nREQUIERE CONTROL DE CINTURONES: {Contexto.ControlCinturones}-" +
                        $"\r\nREQUIERE CONTROL DE BATERIAS: {Contexto.ControlBateria}-" +
                        $"\r\nREQUIERE CONTROL DE PROPULSION: {Contexto.ControlPropulsion}-" +
                        $"\r\nREQUIERE CONTROL DE TRACCION: {Contexto.ControlTraccion}-" +
                        $"\r\nREQUIERE CONTROL DE MOTOR: {Contexto.ControlMotor}-" +
                        $"\r\nREQUIERE CONTROL DE NAVEGACION: {Contexto.ControlNavegacion}";

                Contexto.DatoKmHs = objetoTesla.GetHsActual;
            }
            else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
            {
                EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;

                textBoxEscaner.Text =
                        $"\r\n*** DATOS DEL VEHICULO ***" +
                        $"\r\n" +
                        $"\r\nN° IDENTIFICACION:-- {objetoTesla.GetNId}-" +
                        $"\r\nMODELO:-- {objetoTesla.GetModelo}-" +
                        $"\r\nEMPRESA:-- {objetoTesla.GetEmpresa}-" +
                        $"\r\nAÑO FABRICACION:-- {objetoTesla.GetAnio}-" +
                        $"\r\nHS-ACTUAL: {objetoTesla.GetHsActual} HS-" +
                        $"\r\nHS-ULTIMO SERVICIO:{Contexto.DatoKmHs} HS-" +
                        $"\r\nHS-SIN SERVICIO: {objetoTesla.GetHsActual - Contexto.DatoKmHs} HS-" +
                        $"\r\nCOLOR: {objetoTesla.GetColor}-" +
                        $"\r\n" +
                        $"\r\n*** DATOS TECNICOS DEL VEHICULO ***" +
                        $"\r\n" +
                        $"\r\nAUTONOMIA CON EL {objetoTesla.GetTanqueCombustible} % DE COMBUSTIBLE: {objetoTesla.GetAutonomia} HS-" +
                        $"\r\nREQUERIMIENTO DE SERIVIO CADA : {objetoTesla.GetService} HS-" +
                        $"\r\nCARGA ACTUAL DE LA BATERIAS: {objetoTesla.GetTanqueCombustible} % -" +
                        $"\r\n" +
                        $"\r\n*** REQUERIMIENTOS: RESULTADOS DEL ESCANEO ***" +
                        $"\r\n" +
                        $"\r\nSITUACION: SIN REQUERIMIENTO: {Contexto.SinRequerimientos}-" +
                        $"\r\nREQUIERE CONTROL DE CINTURONES: {Contexto.ControlCinturones}-" +
                        $"\r\nREQUIERE CONTROL DE BATERIAS: {Contexto.ControlBateria}-" +
                        $"\r\nREQUIERE CONTROL DE PROPULSION: {Contexto.ControlPropulsion}-" +
                        $"\r\nREQUIERE CONTROL DE TRACCION: {Contexto.ControlTraccion}-" +
                        $"\r\nREQUIERE CONTROL DE MOTOR: {Contexto.ControlMotor}-" +
                        $"\r\nREQUIERE CONTROL DE NAVEGACION: {Contexto.ControlNavegacion}";

                Contexto.DatoKmHs = objetoTesla.GetHsActual;
            }

        }

        private void ControlSinRequerimiento()
        {
            if (Contexto.SinRequerimientos == true)
            {
                textBoxKmHsServ.Enabled = false;
                buttoneEscanear.Enabled = false;
                buttonRealizarServ.Enabled = false;
                buttonFinalizar.Enabled = true;
                textBoxEscanerService.Text = "****** EL VEHICULO NO REQUIERE PRESTACION DE SERVICIOS ALGUNO - PUEDE FINALIZAR LA OPERACION ******";
            }
            else if (Contexto.SinRequerimientos == false)
            {
                textBoxKmHsServ.Enabled = false;
                buttoneEscanear.Enabled = false;
                buttonRealizarServ.Enabled = true;
                buttonFinalizar.Enabled = false;
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            Contexto.ControlCinturones = false;
            Contexto.ControlBateria = false;
            Contexto.ControlPropulsion = false;
            Contexto.ControlNavegacion = false;
            Contexto.ControlTraccion = false;
            Contexto.ControlMotor = false;
            Contexto.SinRequerimientos = false;

            this.Close();
        }
    }
}
