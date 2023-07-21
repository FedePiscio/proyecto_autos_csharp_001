using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectForms.ClaseEspace
{
    /// <summary>
    /// CLASE ABSTRACTA ESPACE:
    /// En esta clase abstracta vamos a definir los atributos generales a todos las clases ESPACE.
    /// Tambien se encuentra definidos los metodos GETTERS Y SETTERS relacionados a dichos atributos para poder utilizarlos desde las clases hijas.
    /// Esta clase solo se hereda no se podra instanciar.
    /// </summary>
    public abstract class EspaceAbstract
    {
        /// <summary>
        /// ATRIBUTOS:
        /// Numero de Identificacion.
        /// Año de Fabricacion
        /// Horas Actuales
        /// Horas Ultimo Servicio
        /// Color
        /// Empresa
        /// Tanque de Combustible
        /// </summary>

        private int nId;
        private int anio;
        private int hsActual;
        private int hsUltimoServicio;
        private string color;
        private string empresa;
        private int tanqueCombustible;


        /// <summary>
        /// CONSTRUCTIR: 
        /// Definimos los parametros que seran necesarios para crear eo objeto que sera heredado por las hijas.
        /// El atributo de combustible siempre se inicializara en 100 % de tanque lleno.
        /// El atributo de horas ultimo servicio siempre se inicializara en 0.
        /// </summary>
        public EspaceAbstract(int nId, int anio, int hsActual, string color, string empresa)
        {
            this.nId = nId;
            this.anio = anio;
            this.hsActual = hsActual;
            this.color = color;
            this.empresa = empresa;
            this.tanqueCombustible = 100;
            this.hsUltimoServicio = 0;


        }

        /// <summary>
        /// GETTERS Y SETTERS
        /// Definimos los Getters y los Setters para poder consultar y modificar los atributos desde las clases hijas.
        /// </summary>

        public int GetNId
        {
            get { return this.nId; }
        }

        public int GetAnio
        {
            get { return this.anio; }
        }

        public int GetHsActual
        {
            get { return this.hsActual; }
        }

        public int SetNId
        {
            set { this.nId = value; }
        }

        public int SetHsActual
        {
            set { this.hsActual = value; }
        }

        public string GetColor
        {
            get { return this.color; }
        }

        public string GetEmpresa
        {
            get { return this.empresa; }
        }

        public int GetTanqueCombustible
        {
            get { return this.tanqueCombustible; }
        }

        public int SetTanqueCombustible
        {
            set { this.tanqueCombustible = value; }
        }

        public int GetHsUltimoServicio
        {
            get { return this.hsUltimoServicio; }
        }

        public int SetHsUltimoServicio
        {
            set { this.hsUltimoServicio = value; }
        }

    }
}
