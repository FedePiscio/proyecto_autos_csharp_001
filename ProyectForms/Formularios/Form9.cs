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
using ProyectForms.ClasesTesla;
using Proyecto.ClasesTesla;

namespace ProyectForms.Formularios
{
    /// <summary>
    /// CLASE FORMULARIO 9:
    /// En este formulario se realizara un procedimiento de recorrer la lista de objetos del contexto indicando como inicio un año 2023 el cual ira disminuyendo
    /// a medida que se encuentra un objeto con un año inferior al 2023, cuando llega al objeto TESLA MAS VIEJO ya sea 1 o varios los mostrara en pantalla,
    /// requerimiento solicitado por el CLIENTE.
    /// </summary>
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            textBoxTeslaViejo.Enabled = false;

            foreach (Object objeto in Contexto.ListaObjetos)
            {

                if (objeto is TeslaModeloS)
                {
                    TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                    if (Contexto.AnioViejo > objetoTesla.GetAnio)
                    {
                        Contexto.IndiceViejo = Contexto.ListaObjetos.IndexOf(objetoTesla);
                        Contexto.AnioViejo = objetoTesla.GetAnio;
                    }

                }
                else if (objeto is TeslaModeloX)
                {
                    TeslaModeloX objetoTesla = (TeslaModeloX)objeto;
                    if (Contexto.AnioViejo > objetoTesla.GetAnio)
                    {
                        Contexto.IndiceViejo = Contexto.ListaObjetos.IndexOf(objetoTesla);
                        Contexto.AnioViejo = objetoTesla.GetAnio;
                    }
                }
                else if (objeto is TeslaCybertruck)
                {
                    TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;
                    if (Contexto.AnioViejo > objetoTesla.GetAnio)
                    {
                        Contexto.IndiceViejo = Contexto.ListaObjetos.IndexOf(objetoTesla);
                        Contexto.AnioViejo = objetoTesla.GetAnio;
                    }
                }
            }
            List<TeslaAbstract> ObjetosViejos = new List<TeslaAbstract>();

            foreach (Object objeto in Contexto.ListaObjetos)
            {

                if (objeto is TeslaModeloS)
                {
                    TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                    if (Contexto.AnioViejo == objetoTesla.GetAnio)
                    {
                        ObjetosViejos.Add(objetoTesla);
                    }

                }
                else if (objeto is TeslaModeloX)
                {
                    TeslaModeloX objetoTesla = (TeslaModeloX)objeto;
                    if (Contexto.AnioViejo == objetoTesla.GetAnio)
                    {
                        ObjetosViejos.Add(objetoTesla);
                    }
                }
                else if (objeto is TeslaCybertruck)
                {
                    TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;
                    if (Contexto.AnioViejo == objetoTesla.GetAnio)
                    {
                        ObjetosViejos.Add(objetoTesla);
                    }
                }

            }

            string texto = "";
            foreach (TeslaAbstract objeto in ObjetosViejos)
            {
                texto += $"N-ID {objeto.GetNId} - DUEÑO: {objeto.GetDuenio} - AÑO: {objeto.GetAnio}\r\n";
            }
            textBoxTeslaViejo.Text = texto;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTeslaViejo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
