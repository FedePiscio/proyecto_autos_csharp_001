using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto.ClasesTesla
{
    /// <summary>
    /// CLASE TESLA
    /// Creamos una clase abstracta para definir todos los atributos relacionados a las clases tesla que luego seran las que van a heredar las clases hijas.
    /// </summary>
    public abstract class TeslaAbstract
    {
        /// <summary>
        /// ATRIBUTOS:
        /// Numero identificador.
        /// Kilometraje Actual
        /// Kilometraje del Ultimo Servicio.
        /// Color
        /// Dueño
        /// % de Bateria.
        /// </summary>

        private int nId;
        private int anio;
        private int kmActual;
        private int kmUltimoServicio;
        private string color;
        private string duenio;
        private int bateria;
        

        /// <summary>
        /// CONSTRUCTIR:
        /// Definimos el constructor con los atributos que se solicitara por parametros al momento de crear las clases que heredan la clase abstracta o clases hijas.
        /// Los atributos bateria y kilometraje ultimo servicio se inicializan la bateria en 100% tomando como inicio que tiene la bateria completa y el servicio en 0
        /// considerando que si es la primera vez no se le hicieron servicio y de lo contrario se ingresara un valor al momento de hacer el escaneo.
        /// </summary>
        public TeslaAbstract(int nId, int anio, int kmActual,string color, string duenio) 
        { 
            this.nId = nId;
            this.anio = anio;
            this.kmActual = kmActual;
            this.color = color; 
            this.duenio = duenio;
            this.bateria = 100;
            this.kmUltimoServicio = 0;
            

        }

        /// <summary>
        /// GETTERS - SETTERS
        /// Definimos los getters y setters para poder consultar y modificar los atributos desde cualquier parte del programa.
        /// </summary>

        public int GetNId
        {
            get { return this.nId; }
        }
        
        public int GetAnio
        {
            get { return this.anio; }
        }

        public int GetKmActual
        {
            get { return this.kmActual; }
        }

        public int SetNId
        { 
            set { this.nId = value; }
        }

        public int SetKmActual
        {
            set { this.kmActual = value; }
        }

        public string GetColor
        {
            get { return this.color; }
        }

        public string GetDuenio
        {
            get {return this.duenio; }
        }

        public int GetCarga
        {
            get { return this.bateria; }
        }

        public int SetBateria
        {
            set { this.bateria = value; }
        }

        public int GetKmUltimoServicio
        {
            get { return this.kmUltimoServicio; }
        }

        public int SetKmUltimoServicio
        {
            set { this.kmUltimoServicio = value; }
        }
    }
}
