using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProyectForms.ClaseEspace;
using ProyectForms.ClasesContexto;
using ProyectForms.ClasesTesla;
using Proyecto.ClasesTesla;


namespace Proyecto.ClaseEscaner
{
    /// <summary>
    /// CLASE ESCANER: en esta clase se van a ejecutar los metodos que van a lograr que al pasarle como parametro un objeto y el Kilometraje del Ultimo 
    /// control realizado a dicho objeto ya sea Tesla o Espace haga los controles pertinentes para establece la situacion en la que se encuentra dicho objeto
    /// con relacion a los CONTROLES que corresponde en funcion de los kilometros a los cuales no se le realizaron servicios.
    /// </summary>
    public class Escaner
    {
        /// <summary>
        /// ATRIBUTOS:
        /// kM-HS ULTIMO CONTROL: hace referencia al kilometraje-Horas del objeto al momento de realizarser el utlimo control o escaneo.
        /// OBJETO ESCANER: hace referencia al objeto que se le debe pasar como parametro para relizar el escaner.
        /// </summary>
        private int kmUltimoControl;
        private object objetoEscanear;


        /// <summary>
        /// CONSTRUCTOR:
        /// Definimos los 2 parametros que se deberan pasar para ejecutar los metodos de la clase.
        /// </summary>
        public Escaner(int kmUltimoControl, object objetoEscanear) 
        { 
            this.objetoEscanear = objetoEscanear;
            this.kmUltimoControl = kmUltimoControl;
        }

        /// <summary>
        /// ESCANER SISTEMA:
        /// Este metodo al ejecutarse toma el indice del contexto que determinar la posicion del objeto que se encuentra en la lista de objetos del contexto,
        /// al tener el objeto a escanear se controla que tipo de clase representa y define al objeto de ese tipo de clase para luego hacer los controles en funcion
        /// de la clase particular de la que se trate.
        /// En funcion de los controles se determinaros variables booleanas dentro del contexto los cuales se inicializan en false y se iran cambiando a true cuando
        /// se determina que corresponde un controla en particular.
        /// En este punto se podria mejorar el codigo trasladando parte del mismo a la Clase Contexto como es la definicion del Objeto y que retorne la clase ya transformada
        /// a la que corresponda.
        /// </summary>
        public void escanearSistemas()
        {
            // Indice del contexto de define la posicion del objeto a escanear.
            int index = Contexto.Indice;

            // Lista de objetos dentro del contexto.
            object objeto = Contexto.ListaObjetos[index];

            // Inicializacion de las variables control en false.
            Contexto.ControlCinturones = false;
            Contexto.ControlBateria = false;
            Contexto.ControlPropulsion = false;
            Contexto.ControlNavegacion = false;
            Contexto.ControlTraccion = false;
            Contexto.ControlMotor = false;
            Contexto.SinRequerimientos = false;
            
            // Control de si es de TIPO CLASE TESLA MODELO X y controles segun kilometraje de este tipo de objeto.
            if (Contexto.ListaObjetos[index] is TeslaModeloX)
            {
                TeslaModeloX objetoTesla = (TeslaModeloX)objeto;
                int kmSinServicio = objetoTesla.GetKmActual - Contexto.DatoKmHs;
                
                if (kmSinServicio >= 1000)
                {
                    Contexto.ControlCinturones = true;
                    if (kmSinServicio >= 2000) 
                    {
                        Contexto.ControlBateria = true;
                        if (kmSinServicio >= 2500) 
                        {
                            Contexto.ControlNavegacion = true;
                            if (kmSinServicio >= 3000) 
                            {
                                Contexto.ControlTraccion = true;
                                Contexto.ControlMotor = true;
                            }
                        }
                    }
                }
                else
                {
                    Contexto.SinRequerimientos = true;
                }

            }

            // Control de si es de TIPO CLASE TESLA MODELO S y controles segun kilometraje de este tipo de objeto.
            else if (Contexto.ListaObjetos[index] is TeslaModeloS)
            {
                TeslaModeloS objetoTesla = (TeslaModeloS)objeto;
                
                int kmSinServicio = objetoTesla.GetKmActual - Contexto.DatoKmHs;

                if (kmSinServicio >= 1000)
                {
                    Contexto.ControlCinturones = true;
                    if (kmSinServicio >= 2000)
                    {
                        Contexto.ControlBateria = true;
                        if (kmSinServicio >= 2500)
                        {
                            Contexto.ControlNavegacion = true;
                            if (kmSinServicio >= 3000)
                            {
                                Contexto.ControlTraccion = true;
                                Contexto.ControlMotor = true;
                            }
                        }
                    }
                }
                else
                {
                    Contexto.SinRequerimientos = true;
                }
            }

            // Control de si es de TIPO CLASE TESLA MODELO CYBERTRUCK y controles segun kilometraje de este tipo de objeto.
            else if (Contexto.ListaObjetos[index] is TeslaCybertruck)
            {
                TeslaCybertruck objetoTesla = (TeslaCybertruck)objeto;
                
                int kmSinServicio = objetoTesla.GetKmActual - Contexto.DatoKmHs;

                if (kmSinServicio >= 1000)
                {
                    Contexto.ControlCinturones = true;
                    if (kmSinServicio >= 2000)
                    {
                        Contexto.ControlBateria = true;
                        if (kmSinServicio >= 2500)
                        {
                            Contexto.ControlNavegacion = true;
                            if (kmSinServicio >= 3000)
                            {
                                Contexto.ControlTraccion = true;
                                Contexto.ControlMotor = true;
                            }
                        }
                    }
                }
                else
                {
                    Contexto.SinRequerimientos = true;
                }
            }

            // Control de si es de TIPO CLASE ESPACE STARSHIP y controles segun Horas Vuelo de este tipo de objeto.
            else if (Contexto.ListaObjetos[index] is EspaceStarship)
            {
                EspaceStarship objetoTesla = (EspaceStarship)objeto;
                
                int HsSinServicio = objetoTesla.GetHsActual - Contexto.DatoKmHs;

                if (HsSinServicio >= 500)
                {
                    Contexto.ControlNavegacion = true;
                    if (HsSinServicio >= 1000) 
                    {
                        Contexto.ControlPropulsion = true;
                    }
                }
                else
                {
                    Contexto.SinRequerimientos = true;
                }

            }

            // Control de si es de TIPO CLASE ESPACE FALCON 9 y controles segun Horas Vuelo de este tipo de objeto.
            else if (Contexto.ListaObjetos[index] is EspaceFalcon9)
            {
                EspaceFalcon9 objetoTesla = (EspaceFalcon9)objeto;
                
                int HsSinServicio = objetoTesla.GetHsActual - Contexto.DatoKmHs;

                if (HsSinServicio >= 500)
                {
                    Contexto.ControlNavegacion = true;
                    if (HsSinServicio >= 1000)
                    {
                        Contexto.ControlPropulsion = true;
                    }
                }
                else
                {
                    Contexto.SinRequerimientos = true;
                }
            }
        }

    }
}
