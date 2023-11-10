using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Casa : Informacion
    {
        // Atributos
        public string nombre;
        public int edad;
        public bool comprar;
        public string telefono;
        public bool tarjeta;
        // Constructor
        public Casa(string nombre, int edad, string telefono,bool comprar, bool tarjeta)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.comprar = comprar;
            this.telefono = telefono;
            this.tarjeta = tarjeta;
        }

        // Implementación de métodos de la interfaz
        public void MostrarDatos()
        {
            Console.WriteLine($"Datos del clente:");
            Console.WriteLine($"Nombre Completo: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Telefono: {telefono}");
            Console.WriteLine("");
        }

        public double Calcular()
        {
             double precio= 25125253+(25125253*12);
            return precio;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Detalles de la Casa:");
            if (comprar)
            {
                Console.WriteLine($"Fecha de la compra de la casa: {(DateTime.Now)}");
                if (tarjeta)
                {
                    Console.WriteLine("Metodo de pago: Tarjeta");
                }
                else
                {
                    Console.WriteLine("Metodo de pago: Efectivo");
                }
            }
            Console.WriteLine($"Precio de la casa: {Calcular()}");
            Console.WriteLine($"Ubicación de la casa: Bellos Horizontes");
            Console.WriteLine("");


        }
    }
}
