// Crear instancias de las clases
using EjercicioInterfaces;

Casa casa=new Casa ("Roger Ivan Gurdian", 35, "96989665",true,false);
Apartamentos apartamentos = new Apartamentos("Ivan Morales Mejia", 25, "85966514", true);

// Llamar a los métodos de la interfaz
Console.WriteLine("Datos de la clase Casa:");
Console.WriteLine("");
casa.MostrarDatos();
casa.Calcular();
casa.MostrarDetalles();

Console.WriteLine("Datos de la clase Apartamentos:");
Console.WriteLine("");
apartamentos.MostrarDatos();
apartamentos.Calcular();
apartamentos.MostrarDetalles();
