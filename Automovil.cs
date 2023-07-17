using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3Vehiculo
{
    public class Automovil : Vehiculo
    {
        private int puertas;

        public int Puertas
        {
            get { return puertas; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El número de puertas debe ser mayor que 0.");

                puertas = value;
            }
        }

        public string GetInformation()
        {
            string informacionVehiculo = base.GetInformation(); // Obtiene la información del vehículo de la clase base
            return $"{informacionVehiculo}\nCantidad de puertas: {Puertas}";
        }
        public string RunAction()
        {
            string accionVehiculo = base.RunAction(); // Obtiene la acción del vehículo de la clase base
            return $"{accionVehiculo} Automovil";
        }
    }
}
