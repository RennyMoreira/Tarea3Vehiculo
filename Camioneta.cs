using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3Vehiculo
{
    public class Camioneta : Vehiculo
    {
        private double capacidadCarga;

        public double CapacidadCarga
        {
            get { return capacidadCarga; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La capacidad de carga debe ser mayor que 0.");

                capacidadCarga = value;
            }
        }

        public string GetInformation()
        {
            string informacionVehiculo = base.GetInformation(); // Obtiene la información del vehículo de la clase base
            return $"{informacionVehiculo}\nCapacidad de carga: {CapacidadCarga} kg";
        }

        public string RunAction()
        {
            string accionVehiculo = base.RunAction(); // Obtiene la acción del vehículo de la clase base
            return $"{accionVehiculo} Camioneta";
        }
    }
}
