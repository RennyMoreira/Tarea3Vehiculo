using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3Vehiculo
{
    public class Vehiculo
    {
        private string marca;
        private string modelo;
        private int anio;

        public string Marca
        {
            get { return marca; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("La marca no puede estar vacía.");
                marca = value;
            }
        }

        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("El modelo no puede estar vacío.");
                modelo = value;
            }
        }

        public int Anio
        {
            get { return anio; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("El año no es válido.");
                anio = value;
            }
        }

        public string GetInformation()
        {
            return $"Marca: {Marca}\nModelo: {Modelo}\nAño: {Anio}";
        }

        public string RunAction()
        {
            return $"Conduciendo ";
        }
    }
}

