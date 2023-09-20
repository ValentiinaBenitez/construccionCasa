using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicohogar
{
    internal class LivingComedor : Estructura
    {

        public LivingComedor(int ancho, int largo, int cantidadLuces, string colorPared, string tipoPiso, int alto) : base(ancho, largo, cantidadLuces, colorPared, tipoPiso, alto) { }

        public override void acciones()
        {
            Console.WriteLine("Puedo mirar tele.");
            Console.WriteLine("Puedo comer.");
            Console.WriteLine("Puedo tener reuniones.");
        }

        public void ordenar()
        {
            Console.WriteLine("Estoy guardando objetos que están fuera de su lugar");
            Console.WriteLine("...");
            Console.WriteLine("Estoy barriendo");
            Console.WriteLine("...");
            Console.WriteLine("Estoy fregando el piso con fabuloso");
        }

    }
}
