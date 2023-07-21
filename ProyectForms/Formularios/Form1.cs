using ProyectForms.ClaseEspace;
using ProyectForms.ClasesTesla;
using ProyectForms.Formularios;
using ProyectForms.ClasesContexto;
using Proyecto.ClasesTesla;


namespace ProyectForms
{
    /// <summary>
    /// CLASE FORMULARIO 1
    /// En esta clase formulario se definiran los cuatro botones y/o metodos que ejecuten los miemos.
    /// Dentro de esta clase vamos a inicializar 10 objetos en la lista de objetos del Contexto para tener informacion para trabajar.
    /// </summary>
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //- Inicializamos los objetos Tesla y Espace, le pasamos los parametro requeridos para ello.
            TeslaModeloS objeto_1 = new TeslaModeloS(354, 2015, 3500, "Rojo", "Gomesa Martin");
            TeslaModeloX objeto_2 = new TeslaModeloX(400, 1990, 5500, "Gris", "Ramirez Luis");
            TeslaCybertruck objeto_3 = new TeslaCybertruck(312, 2016, 5500, "Rojo", "Fernandez Laura");
            EspaceStarship objeto_4 = new EspaceStarship(512, 2020, 1500, "Verde", "Sanchez Pedro");
            EspaceFalcon9 objeto_5 = new EspaceFalcon9(645, 2000, 2500, "Rojo", "Martinez Fernando");
            TeslaModeloS objeto_6 = new TeslaModeloS(355, 1991, 3500, "Gris", "Rodriguez Laura");
            TeslaModeloX objeto_7 = new TeslaModeloX(125, 1990, 5500, "Verde", "Fuentes Marta");
            TeslaCybertruck objeto_8 = new TeslaCybertruck(310, 2016, 5500, "Gris", "Fernandez Laura");
            EspaceStarship objeto_9 = new EspaceStarship(659, 1990, 1500, "Rojo", "Aguero Pedro");
            EspaceFalcon9 objeto_10 = new EspaceFalcon9(644, 2019, 2500, "Verde", "Lopez Juan");

            //- Realizamos algunos recorridos de algunos objetos para que su bateria que se inicia en 100% se consuma.
            objeto_2.conducir(300);
            objeto_4.recorrido(180);
            objeto_6.conducir(250);
            objeto_9.recorrido(220);

            //- Agregamos los Objetos creados a la lista de objetos definida en el Contexto.
            Contexto.ListaObjetos.Add(objeto_1);
            Contexto.ListaObjetos.Add(objeto_2);
            Contexto.ListaObjetos.Add(objeto_3);
            Contexto.ListaObjetos.Add(objeto_4);
            Contexto.ListaObjetos.Add(objeto_5);
            Contexto.ListaObjetos.Add(objeto_6);
            Contexto.ListaObjetos.Add(objeto_7);
            Contexto.ListaObjetos.Add(objeto_8);
            Contexto.ListaObjetos.Add(objeto_9);
            Contexto.ListaObjetos.Add(objeto_10);



        }

        //- ALTAS: al ejecutarlo nos abrira el formulario 2.
        private void buttonaAltas_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2();
            formulario.Show();

        }

        //- ALTAS: al ejecutarlo nos abrira el formulario 3.
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formulario = new Form3();
            formulario.Show();

        }

        //- ALTAS: al ejecutarlo nos abrira el formulario 8.
        private void button2_Click(object sender, EventArgs e)
        {
            Form8 formulario = new Form8();
            formulario.Show();

        }

        //- ALTAS: al ejecutarlo nos abrira el formulario 9.
        private void buttonTeslaViejo_Click(object sender, EventArgs e)
        {
            Form9 formulario = new Form9();
            formulario.Show();
        }
    }
}