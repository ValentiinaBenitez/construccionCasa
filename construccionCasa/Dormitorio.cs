using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicohogar
{
    internal class Dormitorio : Estructura
    {
        public Dormitorio(int ancho, int largo, int cantidadLuces, string colorPared, string tipoPiso, int alto) : base(ancho, largo, cantidadLuces, colorPared, tipoPiso, alto) { }

        public override void acciones()
        {
            Console.WriteLine("Puedo dormir.");
            Console.WriteLine("Puedo estudiar.");
            Console.WriteLine("Puedo vestirme.");
            Console.WriteLine("Puedo leer un libro.");
        }

        public void ordenar()
        {
            Console.WriteLine("Estoy tendiendo la cama");
            Console.WriteLine("...");
            Console.WriteLine("Estoy limpiando la mesa de luz");
            Console.WriteLine("...");
            Console.WriteLine("Estoy pasando la aspiradora");
            
        }
    }
}
