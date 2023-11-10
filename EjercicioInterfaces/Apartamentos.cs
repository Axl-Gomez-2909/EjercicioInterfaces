using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Apartamentos : Informacion
    {
        // Atributos
        public string nombre;
        public int edad;
        public bool alquiler;
        public string telefono;
        // Constructor
        public Apartamentos(string nombre, int edad, string telefono, bool alquiler)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.alquiler = alquiler;
            this.telefono = telefono;
        }

        // Implementación de métodos de la interfaz
        public void MostrarDatos()
        {
            Console.WriteLine($"Datos del clente:");
            Console.WriteLine($"Nombre Completo: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Telefono: {telefono}");
        }

        public double Calcular()
        {
            double precio = 2569 + (2569 * 12);
            return precio;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Detalles del apartamento");
            Console.WriteLine($"Precio del apartamento: {Calcular()}");
            Console.WriteLine($"Ubicación del apartamento: Residencial Los naranjos");
            Console.WriteLine("");

        }
    }
}
