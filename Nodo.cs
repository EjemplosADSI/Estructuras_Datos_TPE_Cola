namespace Estructuras_Datos_TPE_Cola
{
    public class Nodo
    {
        private int dato;
        private Nodo siguiente;

        public int Dato
        {
            get{return dato;}
            set{dato = value;}
        }
        
        public Nodo Siguiente
        {
            get{return siguiente;}
            set{siguiente = value;}
        }
    }
}