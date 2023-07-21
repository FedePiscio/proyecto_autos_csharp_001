using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.ClasesTesla;
using ProyectForms.ClasesContexto;
using ProyectForms.ClaseEspace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Drawing.Text;
using ProyectForms.ClasesTesla;
using System.Drawing.Imaging;

namespace ProyectForms
{
    /// <summary>
    /// CLASE FORMULARIO 2.
    /// En esta clase vamos a incorporar todo lo relacionado a crear y dar de alta un objeto para luego incorporarlo en la lista de objetos del contexto.
    /// La lista de objetos se expondra para su visualizacion y los parametros requeridos para crear el objeto tendran controles internos para definir
    /// que sea un valor aceptable y valido.
    /// </summary>
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            //-- Definimos los botones en false para cumplir siertos requerimiento previoa a poder ejecutarlos.
            button2FinAlta.Enabled = false;
            button1ValidDatos.Enabled = false;
            button1ModifDato.Enabled = false;

            //-- Definimos el estilo del comboBox para que no puedan ser editables y solo utilizarlos para definir valores predefinidos en su contenido.
            comboBox1Modelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2Color.DropDownStyle = ComboBoxStyle.DropDownList;

            //-- Metodo que permite refrescar la lista cada vez que se ejecuta el formulario.
            refrescarLista();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Click(object sender, EventArgs e)
        {

        }

        //- BOTON VALIDAZION DATOS.
        private void button1_Click(object sender, EventArgs e)
        {
            //- Al ejecutar el boton da validar datos se deshabilitan todas las opciones para ingresa datos que se encuentran ya validados.
            comboBox1Modelo.Enabled = false;
            comboBox2Color.Enabled = false;
            textBox1NId.Enabled = false;
            textBox2Duenio.Enabled = false;
            textBox3Anio.Enabled = false;
            textBox4KmActual.Enabled = false;
            button2FinAlta.Enabled = true;
            button1ModifDato.Enabled = true;

            //- Definimos variables para luego transformarlas a valores validos para su control.
            string datoModelo = comboBox1Modelo.Text;
            int datoId = int.Parse(textBox1NId.Text);
            int datoAnio = int.Parse(textBox3Anio.Text);
            int datoKmActual = int.Parse(textBox4KmActual.Text);
            string datoColor = comboBox2Color.Text;
            string datoDuenio = textBox2Duenio.Text;

            //- Visualizacion de la informacion en pantalla.
            textBoxDatos.Text = $"**** Datos precargados al sistema ****\r\n\r\nMODELO: {datoModelo}\r\nN° IDENTIFICADOR: {datoId}\r\nDUEÑO-EMPRESA: {datoDuenio}\r\nAÑO: {datoAnio}\r\nKM-HS-ACTUAL: {datoKmActual}\r\nCOLOR: {datoColor}\r\n\r\n\r\n**** Controle los datos precargados y de ser correctos FINALICE EL ALTA de los datos ****";

            //- Deshabilitamos el boton validazion datos por haberse ejecutado.
            button1ValidDatos.Enabled = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// CONTROL AÑO:
        /// Este metodo va a realizar el control del valor ingresado como año, el mismo no podra ser diferente a numerico y el mismo tiene que 
        /// estar definido entre valores desde 1900 a 2023.
        /// De no cumplirse con dichos parametros indicara que es un valor incorrecto / dato obligatorio.
        /// De ser valido se indicara como ".OK" valor que se tendra en cuenta para futuros controles. ControlOK()
        /// </summary>
        private void textBox3Anio_TextChanged(object sender, EventArgs e)
        {
            int numero;
            string texto = textBox3Anio.Text;
            bool esNumerico = int.TryParse(texto, out numero);

            if (esNumerico == true)
            {
                if (int.Parse(texto) < 1900 || int.Parse(texto) > 2023)
                {
                    label15Anio.Text = "Valores entre 1900 - 2023";
                    label15Anio.ForeColor = Color.Red;
                    ControlOK();
                }
                else
                {
                    label15Anio.Text = ".OK";
                    label15Anio.ForeColor = Color.Black;
                    ControlOK();
                }

            }

            if (esNumerico == false)
            {
                label15Anio.Text = "Error: Requiere Numerico Valido";
                label15Anio.ForeColor = Color.Red;
                ControlOK();
            }
            if (string.IsNullOrEmpty(texto))
            {
                label15Anio.Text = "* Dato Obligatorio";
                label15Anio.ForeColor = Color.Black;
                ControlOK();
            }


        }

        /// <summary>
        /// CONTROL KILOMETRAJE:
        /// Similar al metodo de control de Año pero el valor debera ser de 0 a 1000000 km u horas.
        /// </summary>
        private void textBox4KmActual_TextChanged(object sender, EventArgs e)
        {
            int numero;
            string texto = textBox4KmActual.Text;
            bool esNumerico = int.TryParse(texto, out numero);

            if (esNumerico == true)
            {
                if (int.Parse(texto) > 1000000 || int.Parse(texto) < 0)
                {
                    label16kmActual.Text = "Valores entre 0 - 1000000 km-hs";
                    label16kmActual.ForeColor = Color.Red;
                    ControlOK();
                }
                else
                {
                    label16kmActual.Text = ".OK";
                    label16kmActual.ForeColor = Color.Black;
                    ControlOK();
                }

            }

            if (esNumerico == false)
            {
                label16kmActual.Text = "Error: Requiere Numerico Valido";
                label16kmActual.ForeColor = Color.Red;
                ControlOK();
            }
            if (string.IsNullOrEmpty(texto))
            {
                label16kmActual.Text = "* Dato Obligatorio";
                label16kmActual.ForeColor = Color.Black;
                ControlOK();
            }
        }

        /// <summary>
        /// CONTROL NUMERO IDENTIFICACION:
        /// Similar al metodo de control anteriores pero se definen valores de 0 a 99999999.
        /// NOTA: en este punto no se realizaron controle de repeticion de valores identificatorios dentro de la lista de objetos. Seria adecuado realizarlo
        /// para que no existan numeros identificatorios repetidos.
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numero;
            string texto = textBox1NId.Text;
            bool esNumerico = int.TryParse(texto, out numero);

            if (esNumerico == true)
            {
                if (int.Parse(texto) < 0 || int.Parse(texto) > 99999999)
                {
                    label12NId.Text = "Valores entre 0 - 99999999";
                    label12NId.ForeColor = Color.Red;
                    ControlOK();
                }
                else
                {
                    label12NId.Text = ".OK";
                    label12NId.ForeColor = Color.Black;
                    ControlOK();

                }

            }

            if (esNumerico == false)
            {
                label12NId.Text = "Error: Requiere Numerico Valido";
                label12NId.ForeColor = Color.Red;
                ControlOK();
            }
            if (string.IsNullOrEmpty(texto))
            {
                label12NId.Text = "* Dato Obligatorio";
                label12NId.ForeColor = Color.Black;
                ControlOK();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// CONTROL MODELO:
        /// En este control se busca que se haya seleccionado un valor de la lsita valido para definir el control como ".OK" 
        /// parametro que se utilizara para realizar controles posteriores. "ControlOK()"
        /// </summary>
        private void comboBox1Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1Modelo.Text == "Tesla Modelo - S")
            {
                label12Modelo.Text = ".OK";
                ControlOK();

            }
            else if (comboBox1Modelo.Text == "Tesla Modelo - X")
            {
                label12Modelo.Text = ".OK";
                ControlOK();

            }
            else if (comboBox1Modelo.Text == "Tesla Modelo - Cybertruck")
            {
                label12Modelo.Text = ".OK";
                ControlOK();

            }
            else if (comboBox1Modelo.Text == "EspaceX - Starship")
            {
                label12Modelo.Text = ".OK";
                ControlOK();

            }
            else if (comboBox1Modelo.Text == "EspaceX - Falcon 9")
            {
                label12Modelo.Text = ".OK";
                ControlOK();

            }
            else if (comboBox1Modelo.Text == null || comboBox1Modelo.Text == string.Empty)
            {
                label12Modelo.Text = "* Dato Obligatorio";
                label12Modelo.ForeColor = Color.Black;
                ControlOK();
            }
            else
            {
                label12Modelo.Text = "* Dato Obligatorio";
                ControlOK();
            }
        }

        /// <summary>
        /// CONTROL DUEÑO:
        /// Similar a los controles anteriores.
        /// El objetivo de este control es que sea un texto, no numerico, se valida las letras con tilde.
        /// Para que se defina el valor ".OK", parametro que se tomara para el "ControlOK()"
        /// </summary>
        private void textBox2Duenio_TextChanged(object sender, EventArgs e)
        {
            // Metodo que nos devolvera true or false si cumple con las condiciones:
            if (Regex.IsMatch(textBox2Duenio.Text, @"^[A-Za-z á Á é É í Í ó Ó ú Ú ñ Ñ \s]+$"))
            {
                label14Duenio.Text = ".OK";
                label14Duenio.ForeColor = Color.Black;
                ControlOK();
            }
            else if (string.IsNullOrEmpty(textBox2Duenio.Text))
            {
                label14Duenio.Text = "* Dato Obligatorio";
                label14Duenio.ForeColor = Color.Black;
                ControlOK();
            }
            else
            {
                label14Duenio.Text = "Error: Solo acepta caracteres";
                label14Duenio.ForeColor = Color.Red;
                ControlOK();
            }

        }

        /// <summary>
        /// CONTROL OK:
        /// Este metodo es el que nos va a definir que todos los parametros ingresados dieron como resultado ".OK" permitiendo
        /// inferir que todos los datos intriducidos por el usuario son validos para poder dar de alta y crear el objeto.
        /// De dar como resultado true el programa habilita el boton de validazion de datos requerimiento para poder seguir ejecutando el programa
        /// de lo contrario se mantendra inhabilitado hasta que todos los valores ingresados resulten en un ".OK"
        /// </summary>
        private void ControlOK()
        {
            if ((label12Modelo.Text == ".OK") && (label12NId.Text == ".OK") && (label14Duenio.Text == ".OK") && (label15Anio.Text == ".OK") && (label16kmActual.Text == ".OK") && (label17Color.Text == ".OK"))
            {
                button1ValidDatos.Enabled = true;

            }
            else
            {
                button1ValidDatos.Enabled = false;

            }
        }

        /// <summary>
        /// CONTROL COLOR:
        /// Similar al control de modelo anterior.
        /// </summary>
        private void comboBox2Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> colores = new List<string> { "Negro", "Blanco", "Gris", "Rojo", "Azul", "Verde", "Amarillo", "Naranja", "Marrón" };

            if (colores.Contains(comboBox2Color.Text))
            {
                label17Color.Text = ".OK";
                label17Color.ForeColor = Color.Black;
                ControlOK();
            }
            else if (comboBox2Color.Text == null)
            {
                label17Color.Text = "* Dato Obligatorio";
                label17Color.ForeColor = Color.Black;
                ControlOK();
            }
            else
            {
                label17Color.Text = "* Dato Obligatorio";
                label17Color.ForeColor = Color.Black;
                ControlOK();
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// BOTON MODIFICAR DATOS:
        /// Si se selecciona se volvera a habilitar todos los datos para poder realizar las modificaciones requeridas
        /// y deshabilitara los botones previamente habilitados para seguir con el proceso del programa.
        /// Seria como volver un paso hacia atras.
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1Modelo.Enabled = true;
            comboBox2Color.Enabled = true;
            textBox1NId.Enabled = true;
            textBox2Duenio.Enabled = true;
            textBox3Anio.Enabled = true;
            textBox4KmActual.Enabled = true;
            button2FinAlta.Enabled = false;
            button1ValidDatos.Enabled = true;
            textBoxDatos.Text = "";
            button1ModifDato.Enabled = false;

        }

        /// <summary>
        /// REFRESCAR LISTA:
        /// Lo que hace este metodo es LIMPIAR la grilla, recorrer toda la lsita de objetos del contexto y en el recorrido y definiendo
        /// el tipo de objeto al que hace referencia y definido el objeto se llama a los metodos propios de dicho objeto para obtener
        /// los datos necesarios para incorporar a la nueva grilla para su posterior visualizacion.
        /// </summary>
        private void refrescarLista()
        {
            //- Limpiamos grilla.
            dataGridView1.Rows.Clear();

            //- Recorremos lista de objetos del contexto
            foreach (Object objeto in Contexto.ListaObjetos)
            {
                //- Agregamos una nueva fila a la grilla.
                dataGridView1.Rows.Add(); 

                //- definimos el indice que sera definido en la ultima fila agregada.
                int filaIndex = dataGridView1.Rows.Count - 1; 

                //- SI ES TESLA MODELO S.
                if (objeto is TeslaModeloS)
                {
                    //- Convertimos el objeto en la clase particular.
                    TeslaModeloS objetoTesla = (TeslaModeloS)objeto;

                    //- Ejecutamos los Getters propios de la clase en cuestion.
                    dataGridView1.Rows[filaIndex].Cells["Column1NId"].Value = objetoTesla.GetNId;
                    dataGridView1.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoTesla.GetModelo;
                    dataGridView1.Rows[filaIndex].Cells["Column2Anio"].Value = objetoTesla.GetAnio;
                    dataGridView1.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoTesla.GetDuenio;
                    dataGridView1.Rows[filaIndex].Cells["Column4"].Value = objetoTesla.GetKmActual;
                    dataGridView1.Rows[filaIndex].Cells["Column5Color"].Value = objetoTesla.GetColor;


                }

                //- SI ES TESLA MODELO X.
                else if (objeto is TeslaModeloX)
                {
                    //- Convertimos el objeto en la clase particular.
                    TeslaModeloX objetoTesla = (TeslaModeloX)objeto;

                    //- Ejecutamos los Getters propios de la clase en cuestion.
                    dataGridView1.Rows[filaIndex].Cells["Column1NId"].Value = objetoTesla.GetNId;
                    dataGridView1.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoTesla.GetModelo;
                    dataGridView1.Rows[filaIndex].Cells["Column2Anio"].Value = objetoTesla.GetAnio;
                    dataGridView1.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoTesla.GetDuenio;
                    dataGridView1.Rows[filaIndex].Cells["Column4"].Value = objetoTesla.GetKmActual;
                    dataGridView1.Rows[filaIndex].Cells["Column5Color"].Value = objetoTesla.GetColor;
                }

                //- SI ES TESLA MODELO CYBERTRUCK.
                else if (objeto is TeslaCybertruck)
                {
                    //- Convertimos el objeto en la clase particular.
                    TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;

                    //- Ejecutamos los Getters propios de la clase en cuestion.
                    dataGridView1.Rows[filaIndex].Cells["Column1NId"].Value = objetoTesla.GetNId;
                    dataGridView1.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoTesla.GetModelo;
                    dataGridView1.Rows[filaIndex].Cells["Column2Anio"].Value = objetoTesla.GetAnio;
                    dataGridView1.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoTesla.GetDuenio;
                    dataGridView1.Rows[filaIndex].Cells["Column4"].Value = objetoTesla.GetKmActual;
                    dataGridView1.Rows[filaIndex].Cells["Column5Color"].Value = objetoTesla.GetColor;
                }

                //- SI ES MODELO ESPACE STARSHIP.
                else if (objeto is EspaceStarship)
                {
                    //- Convertimos el objeto en la clase particular.
                    EspaceStarship objetoEspaceX = (EspaceStarship)objeto;

                    //- Ejecutamos los Getters propios de la clase en cuestion.
                    dataGridView1.Rows[filaIndex].Cells["Column1NId"].Value = objetoEspaceX.GetNId;
                    dataGridView1.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoEspaceX.GetModelo;
                    dataGridView1.Rows[filaIndex].Cells["Column2Anio"].Value = objetoEspaceX.GetAnio;
                    dataGridView1.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoEspaceX.GetEmpresa;
                    dataGridView1.Rows[filaIndex].Cells["Column4"].Value = objetoEspaceX.GetHsActual;
                    dataGridView1.Rows[filaIndex].Cells["Column5Color"].Value = objetoEspaceX.GetColor;
                }

                //- SI ES MODELO ESPACE FALCON 9.
                else if (objeto is EspaceFalcon9)
                {
                    //- Convertimos el objeto en la clase particular.
                    EspaceFalcon9 objetoEspaceX = (EspaceFalcon9)objeto;

                    //- Ejecutamos los Getters propios de la clase en cuestion.
                    dataGridView1.Rows[filaIndex].Cells["Column1NId"].Value = objetoEspaceX.GetNId;
                    dataGridView1.Rows[filaIndex].Cells["Column1Modelo"].Value = objetoEspaceX.GetModelo;
                    dataGridView1.Rows[filaIndex].Cells["Column2Anio"].Value = objetoEspaceX.GetAnio;
                    dataGridView1.Rows[filaIndex].Cells["Column3Duenio"].Value = objetoEspaceX.GetEmpresa;
                    dataGridView1.Rows[filaIndex].Cells["Column4"].Value = objetoEspaceX.GetHsActual;
                    dataGridView1.Rows[filaIndex].Cells["Column5Color"].Value = objetoEspaceX.GetColor;
                }
            }
        }

        /// <summary>
        /// BOTON FINAL ALTA:
        /// Este metodo lo que va a realizar es definir de que tiempo de objeto clase se esta tratando de realizar el alta por parte del usuario
        /// para luego definir dicha clase y crear el objeto pasandoles los parametros indicados y luego realizar la incorporacion del objeto
        /// a la lista de objetos del contexto.
        /// </summary>
        private void button2FinAlta_Click(object sender, EventArgs e)
        {
            //- Definimos los parametros que van a ser utilizados para crear el objeto.
            string datoModelo = comboBox1Modelo.Text;
            int datoId = int.Parse(textBox1NId.Text);
            int datoAnio = int.Parse(textBox3Anio.Text);
            int datoKmHsActual = int.Parse(textBox4KmActual.Text);
            string datoColor = comboBox2Color.Text;
            string datoDuenioEmpresa = textBox2Duenio.Text;

            //- SI ES TESLA MODELO S.
            if (datoModelo == "Tesla Modelo - S")
            {
                //- Creamos el objeto.
                TeslaModeloS vehiculo = new TeslaModeloS(datoId, datoAnio, datoKmHsActual, datoColor, datoDuenioEmpresa);
                //- Agregamos el Objeto a la lista del contexto.
                Contexto.ListaObjetos.Add(vehiculo);
            }

            //- SI ES TESLA MODELO X.
            else if (datoModelo == "Tesla Modelo - X")
            {
                //- Creamos el objeto.
                TeslaModeloX vehiculo = new TeslaModeloX(datoId, datoAnio, datoKmHsActual, datoColor, datoDuenioEmpresa);
                //- Agregamos el Objeto a la lista del contexto.
                Contexto.ListaObjetos.Add(vehiculo);
            }

            //- SI ES TESLA MODELO CYBERTRUCK.
            else if (datoModelo == "Tesla Modelo - Cybertruck")
            {
                //- Creamos el objeto.
                TeslaCybertruck vehiculo = new TeslaCybertruck(datoId, datoAnio, datoKmHsActual, datoColor, datoDuenioEmpresa);
                //- Agregamos el Objeto a la lista del contexto.
                Contexto.ListaObjetos.Add(vehiculo);
            }

            //- SI ES MODELO ESPACE STARSHIP.
            else if (datoModelo == "EspaceX - Starship")
            {
                //- Creamos el objeto.
                EspaceStarship vehiculo = new EspaceStarship(datoId, datoAnio, datoKmHsActual, datoColor, datoDuenioEmpresa);
                //- Agregamos el Objeto a la lista del contexto.
                Contexto.ListaObjetos.Add(vehiculo);
            }

            //- SI ES MODELO ESPACE FALCON 9.
            else if (datoModelo == "EspaceX - Falcon 9")
            {
                //- Creamos el objeto.
                EspaceFalcon9 vehiculo = new EspaceFalcon9(datoId, datoAnio, datoKmHsActual, datoColor, datoDuenioEmpresa);
                //- Agregamos el Objeto a la lista del contexto.
                Contexto.ListaObjetos.Add(vehiculo);
            }

            //- SITUACION NUEVA ALTA: Volvemos todos los parametros a posicion inicial para volver a realizar al alta de un nuevo objeto de ser requerido por el usuario.
            comboBox1Modelo.Enabled = true;
            comboBox1Modelo.Text = null;

            comboBox2Color.Enabled = true;
            comboBox2Color.Text = null;

            textBox1NId.Enabled = true;
            textBox1NId.Text = null;

            textBox2Duenio.Enabled = true;
            textBox2Duenio.Text = null;

            textBox3Anio.Enabled = true;
            textBox3Anio.Text = null;

            textBox4KmActual.Enabled = true;
            textBox4KmActual.Text = null;

            textBoxDatos.Text = null;

            refrescarLista();

            button1ModifDato.Enabled = false;
            button2FinAlta.Enabled = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
