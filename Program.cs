using System;

namespace TareaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada miLista = new ListaEnlazada();

            // Agregamos datos de prueba
            miLista.AgregarEstudiante(new Estudiante("1712345678", "Santiago", "Pérez", "santiago@correo.com", 9.5));
            miLista.AgregarEstudiante(new Estudiante("1700000001", "Ana", "García", "ana@correo.com", 5.0));

            Console.WriteLine("=== REGISTRO DE ESTUDIANTES (EJERCICIO 6) ===");
            miLista.MostrarLista();

            Console.WriteLine("\n=== BÚSQUEDA DE DATOS (EJERCICIO 3) ===");
            Console.Write("Ingrese la cédula a buscar: ");
            string cedula = Console.ReadLine();
            
            int encontrados = miLista.BuscarPorCedula(cedula);
            if (encontrados > 0) {
                Console.WriteLine($"El dato fue encontrado {encontrados} veces.");
            }

            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}