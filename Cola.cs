using System;

namespace Estructuras_Datos_TPE_Cola
{
    public class Cola
    {
        private Nodo Primero = new Nodo();

        public Cola()
        {
            Primero = null;
        }

        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            System.Console.WriteLine("Ingrese el dato de la pila");
            nuevo.Dato = int.Parse(Console.ReadLine());
            
            nuevo.Siguiente = Primero;
            Primero = nuevo;
            
            System.Console.WriteLine("\n Nodo Ingresado\n\n");

        }

        public void desplegarCola()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    System.Console.WriteLine(" "+Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                System.Console.WriteLine("\n La cola se encuentra vacia\n\n");
            }
        }

    }
}