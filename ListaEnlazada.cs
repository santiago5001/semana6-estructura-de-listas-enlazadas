using System;

namespace TareaListas
{
    public class Nodo
    {
        public Estudiante Estudiante;
        public Nodo Siguiente;

        public Nodo(Estudiante estudiante)
        {
            Estudiante = estudiante;
            Siguiente = null;
        }
    }

    public class ListaEnlazada
    {
        private Nodo cabeza;

        public void AgregarEstudiante(Estudiante est)
        {
            Nodo nuevo = new Nodo(est);
            if (est.NotaDefinitiva >= 7) 
            {
                nuevo.Siguiente = cabeza;
                cabeza = nuevo;
            }
            else 
            {
                if (cabeza == null) {
                    cabeza = nuevo;
                } else {
                    Nodo actual = cabeza;
                    while (actual.Siguiente != null) {
                        actual = actual.Siguiente;
                    }
                    actual.Siguiente = nuevo;
                }
            }
        }

        public int BuscarPorCedula(string cedula)
        {
            int contador = 0;
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Estudiante.Cedula == cedula) {
                    contador++;
                }
                actual = actual.Siguiente;
            }
            if (contador == 0) {
                Console.WriteLine("Dato no encontrado.");
            }
            return contador;
        }

        public void MostrarLista()
        {
            Nodo actual = cabeza;
            while (actual != null) {
                Console.WriteLine(actual.Estudiante.ToString());
                actual = actual.Siguiente;
            }
        }
    }
}