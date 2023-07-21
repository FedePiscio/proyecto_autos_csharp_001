using ProyectForms.ClasesTesla;
using ProyectForms.ClaseEspace;
using Proyecto.ClasesTesla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectForms.ClasesContexto
{
    /// <summary>
    /// CLASE CONTEXTO
    /// La clase contexto es una clase Estatica que la vamos a utilizar como intermediario entre Las clases y los formularios.
    /// La utilizaremos para guardar las variables que necesita el sistema ya sea hacer los controles, buscar objetos en una lista de objetos, crear la lista de objetos
    /// donde se iran guardando los objeto que se carguen, sera de tipo object (general).
    /// Incluye sus Gettesr y Setters para consultar o modificar las variables a lo largo de la ejecucion del programa.
    /// NOTA: hay mucho codigo que se puede mejorar y sintetizar variables, parametros y metodos.
    /// </summary>
    public class Contexto
    {
        //- Definimos la lista de objetos donde se guardaran todos los objetos Tipo Object (tipo general a todos los objetos).
        private static List<object> listaObjetos = new List<object>();

        //- INDICE: es la variable que me permitira guardar el indice que sera buscado dentro de la lista para contrar la posicion del objeto con el cual se va a operar.
        private static int indice;

        //- INDICE VIEJO: hace referencia al indice del objeto tesla mas viejo para luego poder obtenerlo al momento de solicitarlo.
        private static int indiceViejo;

        //- AÑO MAS VIEJO: es la variable que se inicializara en el año actual y ira disminuyendo a medida que se reconoce dentro de la lista un objeto tesla con un año menor, dato que ira guardado.
        private static int anioViejo = 2023;
        
        //- INDICE A ELIMINAR: sera la variable que guardara el dato de la posicion del objeto que se busca al momento de solicitar la eliminacion del mismo.
        private static int indiceEliminar;

        //- KILOMETOS HORAS: guarda el dato de kilometros u horas que sera utilizado por diferentes operaciones del programa como es el movimiento de los vehiculos.
        private static int datoKmHs;

        //- KILOMETRO HORAS ULTIMO SERVICIO: guardara el dato de la posicion que tenia un objeto al momento de realizarse el ultimo servicio, posicion a tener en cuenta al momento de realizar escaneos.
        private static int datoKmHsUltimoServ;

        //- CONTROLES: estas variables se inicializaran en false y se iran modificando al momento que se realiza el escaneo y dicha operacion indique que hay cierots controles que se deberan realizar.
        private static bool controlCinturones = false;
        private static bool controlBateria = false;
        private static bool controlPropulsion = false;
        private static bool controlNavegacion = false;
        private static bool controlTraccion = false;
        private static bool controlMotor = false;

        //- SIN REQUERIMIENTOS: esta variables es particular por que nos indicara que si todos los controles son false no requiere requerimientos, y si alguno es true si requiere servicios.
        private static bool sinRequerimientos = false;

        //- AUTONOMIA MINIMA: esta variable se inicializara en false y se modificara a true cuando la autonomia llegue a un punto minimo a partir de dicho punto se recomendara cargar bateria / combustible.
        private static bool autonomiaMin = false;

        /// <summary>
        /// GETTERS - SETTERS
        /// Definimos los metodos getters setters para poder consultar y modificar las variables al momento de operar con el resto de las clases dentro del programa.
        /// </summary>


        public static List<object> ListaObjetos
        {
            get { return listaObjetos; }
            set { listaObjetos = value; }
        }

        public static int Indice 
        { 
            get { return indice; }
            set { indice = value; }
        }

        public static int IndiceViejo
        {
            get { return indiceViejo; }
            set { indiceViejo = value; }
        }

        public static int AnioViejo
        {
            get { return anioViejo; }
            set { anioViejo= value; }
        }
        public static int IndiceEliminar
        {
            get { return indiceEliminar; }
            set { indiceEliminar = value; }
        }

        public static int DatoKmHs
        {
            get { return datoKmHs; }
            set { datoKmHs = value; }
        }

        public static int DatoKmHsUltimoServ
        {
            get { return datoKmHsUltimoServ; }
            set { datoKmHsUltimoServ = value; }
        }

        public static bool ControlBateria
        {
            get { return controlBateria; }
            set { controlBateria = value; }
        }

        public static bool ControlPropulsion
        {
            get { return controlPropulsion; }
            set { controlPropulsion = value; }
        }
        public static bool AutonomiaMin
        {
            get { return autonomiaMin; }
            set { autonomiaMin = value; }
        }


        public static bool ControlNavegacion
        {
            get { return controlNavegacion; }
            set { controlNavegacion = value; }
        }

        public static bool ControlTraccion
        {
            get { return controlTraccion; }
            set { controlTraccion = value; }
        }

        public static bool ControlMotor
        {
            get { return controlMotor; }
            set { controlMotor = value; }
        }

        public static bool ControlCinturones
        {
            get { return controlCinturones; }
            set { controlCinturones = value; }
        }
        public static bool SinRequerimientos
        {
            get { return sinRequerimientos; }
            set { sinRequerimientos = value; }
        }

    }
}
