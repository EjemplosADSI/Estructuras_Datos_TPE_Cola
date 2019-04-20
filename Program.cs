using System;

namespace Estructuras_Datos_TPE_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola c = new Cola();

            c.insertarNodo();
            c.insertarNodo();
            c.insertarNodo();
            c.insertarNodo();
            c.insertarNodo();

            System.Console.WriteLine("\n Cola Ingresada:\n");
            c.desplegarCola();
        }
    }
}
