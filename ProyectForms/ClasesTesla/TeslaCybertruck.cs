using ProyectForms.ClasesContexto;
using Proyecto.ClasesTesla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectForms.ClasesTesla
{
    /// <summary>
    /// CLASE INDIVIDUAL: TESLA
    /// Individualizamos un modelo Tesla por cada clase la cual heredara la clase abstracta TeslaAbstrac la cual no se puede instanciar.
    /// En esta clase individualizada se le definira el modelo, autonomia, servicio y asientos propias de la clase en cuestion.
    /// Tendre metodos como conducir y cargar bateria.
    /// </summary>

    public class TeslaCybertruck : TeslaAbstract
    {

        /// <summary>
        /// ATRIBUTOS:
        /// Son atributos individuales a la propia clase.
        /// Autonomia.
        /// Asientos.
        /// Service.
        /// Modelo
        /// </summary>
        private int autonomia;
        private int asientos;
        private int service;
        private string modelo;

        /// <summary>
        /// CONSTRUCTIR:
        /// Definimos los atributos que se solicitaran como parametros, los cuales vienen heredados de la clase abstracta.
        /// Los atributos propios de la clase se inicializan en la misma ya que son valores constantes propias de la clase en cuestion.
        /// </summary>
        public TeslaCybertruck(int nId, int anio, int kmActual, string color, string duenio) : base(nId, anio, kmActual, color, duenio)
        {
            this.autonomia = 800;
            this.asientos = 6;
            this.service = 3000;
            this.modelo = "Tesla - Cybertruck";

        }

        /// <summary>
        /// GETTERS - SETTERS:
        /// Definimos los getters - setters que nos permitiran consultar y/o modificar los atributos desde cualquier parte del programa o desde las diferentes clases o metodos.
        /// </summary>

        public int GetAutonomia
        {
            get { return this.autonomia; }
        }

        public int GetAsientos
        {
            get { return this.asientos; }
        }

        public int GetService
        {
            get { return this.service; }
        }

        public string GetModelo
        {
            get { return this.modelo; }
        }

        /// <summary>
        /// METODO CONDUCIR:
        /// Este metodo solicita como parametro un Kilometraje a Recorrer que sera el que se toma como parametro para realizar el recorrido y disminuir de forma
        /// proporcional % de bateria que se vaya a consumir. Cuando el valor final de autonomia de por de bajo de 20 km se recomendara realizar una carga previa
        /// a volver a realizar un recorrido.
        /// </summary>
        public void conducir(int kmRecorrer)
        {
            //-- Autonomia menor a 20 kilometros indica que requiere carga de bateria antes de volver a conducir. 
            if (this.autonomia < 20)
            {
                Contexto.AutonomiaMin = true;
            }

            //-- Autonomia mayor a 20 indica que puede realizar un recorrido, se consumira bateria al realizarlo.
            else
            {
                if (kmRecorrer > this.autonomia)
                {
                    kmRecorrer = this.autonomia;
                    double consumoDouble = ((double)kmRecorrer / 800) * 100;
                    int consumo = (int)consumoDouble;
                    this.SetKmActual = (this.GetKmActual + kmRecorrer);
                    this.autonomia = this.autonomia - kmRecorrer;
                    this.SetBateria = this.GetCarga - consumo;

                }
                if (kmRecorrer < this.autonomia)
                {
                    double consumoDouble = ((double)kmRecorrer / 800) * 100;
                    int consumo = (int)consumoDouble;
                    this.SetBateria = this.GetCarga - consumo;
                    this.SetKmActual = (this.GetKmActual + kmRecorrer);
                    this.autonomia = this.autonomia - kmRecorrer;

                }

            }
        }

        /// <summary>
        /// METODO CARGAR BATERIA:
        /// Este metodo es el que nos permitira volver a cargar al 100 % la bateria y volver a generar autonomia para volver a realizar recorridos.
        /// </summary>
        public void cargarBateria()
        {
            this.SetBateria = 100;
            this.autonomia = 650;
        }

    }
}
