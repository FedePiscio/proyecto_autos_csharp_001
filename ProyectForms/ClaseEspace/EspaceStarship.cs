using ProyectForms.ClasesContexto;
using Proyecto.ClasesTesla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectForms.ClaseEspace
{
    /// <summary>
    /// CLASE ESPACE STARSHIP
    /// Definimos los atributos y metodos relacionados a la clase STARSHIP.
    /// La misma hereda la clase abstracta EspaceAbstract, sus atributos y sus metodos.
    /// </summary>
    public class EspaceStarship : EspaceAbstract
    {

        /// <summary>
        /// ATRIBUTOS particulares de la Clase:
        /// Autonomia del vehiculo
        /// Service a partir del cual es recomendable realizar los servicios.
        /// Modedlo.
        /// </summary>
        private int autonomia;
        private int service;
        private string modelo;

        /// <summary>
        /// CONSTRUCTIR:
        /// Los atributos que se pasan por parametro se heredan de la clase abstracta.
        /// Los atributos propios de la clase se encuentran predefinidos y en funcion de la clase particular.
        /// </summary>
        public EspaceStarship(int nId, int anio, int hsActual, string color, string empresa) : base(nId, anio, hsActual, color, empresa)
        {
            this.autonomia = 500;
            this.service = 1000;
            this.modelo = "EspaceX - Starship";

        }

        /// <summary>
        /// GETTERS / SETTERS:
        /// Definimos los Getters y los Setters que seran utilizados para consultar o modificar los atributos de la clase en particular.
        /// </summary>

        public int GetAutonomia
        {
            get { return this.autonomia; }
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
        /// METODO RECORRIDO
        /// Este metodo permitira que al pasarle un parametro de horas a recorrer el objeto consuma parte de la autonomia establecida en funcion
        /// del % de combustible en el tanque, de forma proporcional para que cuando se mueva el objeto disminuya la autonomia y en la misma proporcion
        /// vaya consumiendo parte del combustible del tanque. 
        /// </summary>

        public void recorrido(int kmRecorrer)
        {
            // Si la autonomia es menor a 20 hs se recomienda que se cargue el combustible. Se define como true la variable del contexto que se usa de control.
            if (this.autonomia < 20)
            {
                Contexto.AutonomiaMin = true;
            }
            // Si la autonomia supera las 20 hs se podra viajar hasta consumirla misma.
            else
            {
                if (kmRecorrer > this.autonomia)
                {
                    kmRecorrer = this.autonomia;
                    double consumoDouble = ((double)kmRecorrer / 500) * 100;
                    int consumo = (int)consumoDouble;

                    this.SetHsActual = (this.GetHsActual + kmRecorrer);
                    this.autonomia = this.autonomia - kmRecorrer;
                    this.SetTanqueCombustible = this.GetTanqueCombustible - consumo;


                }
                if (kmRecorrer < this.autonomia)
                {

                    double consumoDouble = ((double)kmRecorrer / 500) * 100;
                    int consumo = (int)consumoDouble;

                    this.SetTanqueCombustible = this.GetTanqueCombustible - consumo;
                    this.SetHsActual = (this.GetHsActual + kmRecorrer);
                    this.autonomia = this.autonomia - kmRecorrer;

                }
            }
        }

        /// <summary>
        /// METODO CARGAR TANQUE COMBUSTIBLE
        /// Este metodo permite realizar una carga completa del tanque de combustible para poder seguir realizando recorridos o viajes.
        /// Al cargarse el tanque de combustible la autonomia vuelve a aumentar al maximo junto con el tanque de combustiblle.
        /// </summary>
        public void cargarTanqueCombustible()
        {
            this.SetTanqueCombustible = 100;
            this.autonomia = 500;
        }

    }
}

