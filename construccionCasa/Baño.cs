using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicohogar
{
    internal class Baño : Estructura
    {
        public Baño(int ancho, int largo, int cantidadLuces, string colorPared, string tipoPiso, int alto) : base(ancho, largo, cantidadLuces, colorPared, tipoPiso, alto) { }

        public override void acciones()
        {
            Console.WriteLine("Puedo bañarme.");
            Console.WriteLine("Puedo cepillarme los dientes.");
            Console.WriteLine("Puedo hacer mis necesidades biológicas.");
        }

        public void ordenar()
        {
            Console.WriteLine("Estoy limpiando el lavamanos y el estante con limpiamueble");
            Console.WriteLine("...");
            Console.WriteLine("Estoy limpiando el espejo con limpiavidrio");
            Console.WriteLine("...");
            Console.WriteLine("Estoy pasando la fregona con fabuloso");
        }

        public override void mejorarEstructura(Estructura estructura)
        {
            int metrosCuadrados = estructura.getAncho() * estructura.getLargo();
            int costoMejora;

            if (metrosCuadrados <= 9)
            {
                costoMejora = 7000;
            } 
            else
            {
                costoMejora = 10000;
            }

            Console.WriteLine("Cambios:");
            Console.WriteLine("- Mayor presión de agua.");
            Console.WriteLine("- Agua caliente en el lavamanos.");
            Console.WriteLine("- Remodelamiento de tuberías.");
            Console.WriteLine("El costo es de $" + costoMejora);
        }
    }
}
