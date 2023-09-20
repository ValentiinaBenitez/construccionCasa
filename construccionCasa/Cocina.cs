using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicohogar
{
    internal class Cocina : Estructura
    {
        public Cocina(int ancho, int largo, int cantidadLuces, string colorPared, string tipoPiso, int alto) : base(ancho, largo, cantidadLuces, colorPared, tipoPiso, alto) { }

        public override void acciones()
        {
            Console.WriteLine("Puedo cocinar.");
            Console.WriteLine("Puedo comer.");
            Console.WriteLine("Puedo fregar.");
        }

        public void ordenar()
        {
            Console.WriteLine("Estoy ordenando la alacena");
            Console.WriteLine("...");
            Console.WriteLine("Estoy limpiando la heladera");
            Console.WriteLine("...");
            Console.WriteLine("Estoy desengrasando la cocina y el horno");
        }

        public override void mejorarEstructura(Estructura estructura)
        {
            int valorDetectorDeHumo = 454;
            int largoCocina = estructura.getLargo();
            int anchoCocina = estructura.getAncho();
            int costoManoDeObra = 2900;
            int cantidadDetectorDeHumo;

            if (anchoCocina <= 3)
            {
                cantidadDetectorDeHumo = 1;
            } 
            else if (anchoCocina > 3 && anchoCocina <= 6)
            {
                cantidadDetectorDeHumo = 2;
            } 
            else  { cantidadDetectorDeHumo = 3; }

            if (largoCocina <= 4) 
            { }
            else if (largoCocina > 4 && largoCocina <= 8)
            {
                cantidadDetectorDeHumo = cantidadDetectorDeHumo * 2;
            } 
            else { cantidadDetectorDeHumo = cantidadDetectorDeHumo * 3; }

            int costoTotal = ((cantidadDetectorDeHumo * valorDetectorDeHumo) + costoManoDeObra);

            Console.WriteLine("Se agrega detector de humo.");
            Console.WriteLine("- Valor por detector de humo: $" + valorDetectorDeHumo);
            Console.WriteLine("- Cantidad necesaria de detectores: " + cantidadDetectorDeHumo);
            Console.WriteLine("- Costo total de detectores: $" + (cantidadDetectorDeHumo * valorDetectorDeHumo));
            Console.WriteLine("- Costo mano de obra: $" + costoManoDeObra);
            Console.WriteLine("- Costo total: $" + costoTotal);
        }
    }
}
