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
    /// CLASE FORMULARIO 8:
    /// Con este formulario el objetivo es VISUALIZACION de la totalida de los datos de forma conjunta, con los datos de Carga de todos los vehiculos que
    /// es requisito solicitado por el cliente.
    /// </summary>
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            refrescarLista();
        }

        public void refrescarLista()
        {

            dataGridView1.Rows.Clear();

            foreach (Object objeto in Contexto.ListaObjetos)
            {
                dataGridView1.Rows.Add(); // Agrega una nueva fila al DataGridView

                int filaIndex = dataGridView1.Rows.Count - 1; // Obtiene el índice de la última fila agregada
                if (objeto is TeslaModeloS)
                {
                    TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                    dataGridView1.Rows[filaIndex].Cells["Col_indice"].Value = filaIndex;
                    dataGridView1.Rows[filaIndex].Cells["Column1NId"].Value = objetoTesla.GetNId;
                    dataGridView1.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoTesla.GetModelo;
                    dataGridView1.Rows[filaIndex].Cells["Column2Anio"].Value = objetoTesla.GetAnio;
                    dataGridView1.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoTesla.GetDuenio;
                    dataGridView1.Rows[filaIndex].Cells["Column5Color"].Value = objetoTesla.GetColor;
                    dataGridView1.Rows[filaIndex].Cells["Col_Ultimo_Serv"].Value = objetoTesla.GetKmUltimoServicio;
                    dataGridView1.Rows[filaIndex].Cells["Column4"].Value = objetoTesla.GetKmActual;
                    dataGridView1.Rows[filaIndex].Cells["Col_Sin_Serv"].Value = (objetoTesla.GetKmActual - objetoTesla.GetKmUltimoServicio);
                    dataGridView1.Rows[filaIndex].Cells["Column1Carga"].Value = objetoTesla.GetCarga;
                    dataGridView1.Rows[filaIndex].Cells["Column1Autonomia"].Value = objetoTesla.GetAutonomia;
                    dataGridView1.Rows[filaIndex].Cells["Column1Asientos"].Value = objetoTesla.GetAsientos;


                }
                else if (objeto is TeslaModeloX)
                {
                    TeslaModeloX objetoTesla = (TeslaModeloX)objeto;

                    dataGridView1.Rows[filaIndex].Cells["Col_indice"].Value = filaIndex;
                    dataGridView1.Rows[filaIndex].Cells["Column1NId"].Value = objetoTesla.GetNId;
                    dataGridView1.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoTesla.GetModelo;
                    dataGridView1.Rows[filaIndex].Cells["Column2Anio"].Value = objetoTesla.GetAnio;
                    dataGridView1.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoTesla.GetDuenio;
                    dataGridView1.Rows[filaIndex].Cells["Column5Color"].Value = objetoTesla.GetColor;
                    dataGridView1.Rows[filaIndex].Cells["Col_Ultimo_Serv"].Value = objetoTesla.GetKmUltimoServicio;
                    dataGridView1.Rows[filaIndex].Cells["Column4"].Value = objetoTesla.GetKmActual;
                    dataGridView1.Rows[filaIndex].Cells["Col_Sin_Serv"].Value = (objetoTesla.GetKmActual - objetoTesla.GetKmUltimoServicio);
                    dataGridView1.Rows[filaIndex].Cells["Column1Carga"].Value = objetoTesla.GetCarga;
                    dataGridView1.Rows[filaIndex].Cells["Column1Autonomia"].Value = objetoTesla.GetAutonomia;
                    dataGridView1.Rows[filaIndex].Cells["Column1Asientos"].Value = objetoTesla.GetAsientos;
                }
                else if (objeto is TeslaCybertruck)
                {
                    TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;

                    dataGridView1.Rows[filaIndex].Cells["Col_indice"].Value = filaIndex;
                    dataGridView1.Rows[filaIndex].Cells["Column1NId"].Value = objetoTesla.GetNId;
                    dataGridView1.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoTesla.GetModelo;
                    dataGridView1.Rows[filaIndex].Cells["Column2Anio"].Value = objetoTesla.GetAnio;
                    dataGridView1.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoTesla.GetDuenio;
                    dataGridView1.Rows[filaIndex].Cells["Column5Color"].Value = objetoTesla.GetColor;
                    dataGridView1.Rows[filaIndex].Cells["Col_Ultimo_Serv"].Value = objetoTesla.GetKmUltimoServicio;
                    dataGridView1.Rows[filaIndex].Cells["Column4"].Value = objetoTesla.GetKmActual;
                    dataGridView1.Rows[filaIndex].Cells["Col_Sin_Serv"].Value = (objetoTesla.GetKmActual - objetoTesla.GetKmUltimoServicio);
                    dataGridView1.Rows[filaIndex].Cells["Column1Carga"].Value = objetoTesla.GetCarga;
                    dataGridView1.Rows[filaIndex].Cells["Column1Autonomia"].Value = objetoTesla.GetAutonomia;
                    dataGridView1.Rows[filaIndex].Cells["Column1Asientos"].Value = objetoTesla.GetAsientos;
                }
                else if (objeto is EspaceStarship)
                {
                    EspaceStarship objetoEspaceX = (EspaceStarship)objeto;


                    dataGridView1.Rows[filaIndex].Cells["Col_indice"].Value = filaIndex;
                    dataGridView1.Rows[filaIndex].Cells["Column1NId"].Value = objetoEspaceX.GetNId;
                    dataGridView1.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoEspaceX.GetModelo;
                    dataGridView1.Rows[filaIndex].Cells["Column2Anio"].Value = objetoEspaceX.GetAnio;
                    dataGridView1.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoEspaceX.GetEmpresa;
                    dataGridView1.Rows[filaIndex].Cells["Column5Color"].Value = objetoEspaceX.GetColor;
                    dataGridView1.Rows[filaIndex].Cells["Col_Ultimo_Serv"].Value = objetoEspaceX.GetHsUltimoServicio;
                    dataGridView1.Rows[filaIndex].Cells["Column4"].Value = objetoEspaceX.GetHsActual;
                    dataGridView1.Rows[filaIndex].Cells["Col_Sin_Serv"].Value = (objetoEspaceX.GetHsActual - objetoEspaceX.GetHsUltimoServicio);
                    dataGridView1.Rows[filaIndex].Cells["Column1Carga"].Value = objetoEspaceX.GetTanqueCombustible;
                    dataGridView1.Rows[filaIndex].Cells["Column1Autonomia"].Value = objetoEspaceX.GetAutonomia;
                    dataGridView1.Rows[filaIndex].Cells["Column1Asientos"].Value = "0";

                }
                else if (objeto is EspaceFalcon9)
                {
                    EspaceFalcon9 objetoEspaceX = (EspaceFalcon9)objeto;

                    dataGridView1.Rows[filaIndex].Cells["Col_indice"].Value = filaIndex;
                    dataGridView1.Rows[filaIndex].Cells["Column1NId"].Value = objetoEspaceX.GetNId;
                    dataGridView1.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoEspaceX.GetModelo;
                    dataGridView1.Rows[filaIndex].Cells["Column2Anio"].Value = objetoEspaceX.GetAnio;
                    dataGridView1.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoEspaceX.GetEmpresa;
                    dataGridView1.Rows[filaIndex].Cells["Column5Color"].Value = objetoEspaceX.GetColor;
                    dataGridView1.Rows[filaIndex].Cells["Col_Ultimo_Serv"].Value = objetoEspaceX.GetHsUltimoServicio;
                    dataGridView1.Rows[filaIndex].Cells["Column4"].Value = objetoEspaceX.GetHsActual;
                    dataGridView1.Rows[filaIndex].Cells["Col_Sin_Serv"].Value = (objetoEspaceX.GetHsActual - objetoEspaceX.GetHsUltimoServicio);
                    dataGridView1.Rows[filaIndex].Cells["Column1Carga"].Value = objetoEspaceX.GetTanqueCombustible;
                    dataGridView1.Rows[filaIndex].Cells["Column1Autonomia"].Value = objetoEspaceX.GetAutonomia;
                    dataGridView1.Rows[filaIndex].Cells["Column1Asientos"].Value = "0";
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
