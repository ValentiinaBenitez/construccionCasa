using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicohogar
{
    internal abstract class Estructura
    {
        protected int ancho;
        protected int largo;
        protected int cantidadLuces;
        protected string colorPared;
        protected string tipoPiso;
        protected int alto;

        public Estructura(int ancho, int largo, int cantidadLuces, string colorPared, string tipoPiso, int alto) 
        {
            this.ancho = ancho;
            this.largo = largo;
            this.cantidadLuces = cantidadLuces;
            this.colorPared = colorPared;
            this.tipoPiso = tipoPiso;
            this.alto = alto;
        }

        public int getAncho() => ancho;
        
        public int getLargo() => largo;
      
        public int getAlto() => alto;
        
        public int getCantidadLuces() => cantidadLuces;
        
        public string getColorPared() => colorPared;
        
        public string getTipoPiso() => tipoPiso;

        public void setAncho(int ancho) => this.ancho = ancho;
        
        public void setLargo(int largo) => this.largo = largo;

        public void setCantidadLuces(int cantidadLuces) => this.cantidadLuces = cantidadLuces;

        public void setColorPared(string colorPared) => this.colorPared = colorPared;

        public void setTipoPiso(string tipoPiso) => this.tipoPiso = tipoPiso;

        public void setAlto(int alto) => this.alto = alto;  
        

        public void cambiarPisos(Estructura estructura)
        {
            int metrosCuadradosTotales = estructura.getAncho() * estructura.getLargo();
            int valorBaldosaPorM2 = 359;
            int costoMaterialesExtras = 2500;
            int costoManoDeObra = 4700;
            int costoTotal = (metrosCuadradosTotales * valorBaldosaPorM2) + costoManoDeObra + costoMaterialesExtras;
            Console.WriteLine("Valor por baldosa: $" + valorBaldosaPorM2);
            Console.WriteLine("Costo total de baldosas: $" + (metrosCuadradosTotales * valorBaldosaPorM2));
            Console.WriteLine("Costo de materiales extras: $" + costoMaterialesExtras);
            Console.WriteLine("Costo mano de obra: $" + costoManoDeObra);
            Console.WriteLine("Costo total: $" + costoTotal);
        }

        public void pintarPared(Estructura estructura)
        {
            int dimensionPared = estructura.getLargo() * estructura.getAlto();
            int valorTarroPintura = 1200;
            int tarrosPorPared;
            
            if (dimensionPared <= 9)
            {
                tarrosPorPared = 1;
            } 
            else
            {
                tarrosPorPared = 2;
            }

            int cantidadTotalDeTarros = tarrosPorPared * 3;
            int costoTotal = cantidadTotalDeTarros * valorTarroPintura;
            Console.WriteLine("Valor por tarro de pintura: $" + valorTarroPintura);
            Console.WriteLine("Cantidad de tarros por pared: " + tarrosPorPared);
            Console.WriteLine("Cantidad total de tarros: " + cantidadTotalDeTarros);
            Console.WriteLine("Costo total: $" + costoTotal);
        }

        public abstract void acciones();

        public virtual void mejorarEstructura(Estructura estructura)
        {
            int cantidadLuces = estructura.getCantidadLuces();
            int valorInterruptor = 689;

            int cantidadInterruptores = cantidadLuces / 3;

            if (cantidadLuces % 3 == 1)
            {
                cantidadInterruptores += 1;
            }

            int valorTotalDeInterruptores = cantidadInterruptores * valorInterruptor;
            int manoDeObra = 3000;
            int costoTotal = valorTotalDeInterruptores + manoDeObra;

            Console.WriteLine("Se añade luz inteligente.");
            Console.WriteLine("- Valor por interruptor: $" + valorInterruptor);
            Console.WriteLine("- Cantidad de interruptores: " + cantidadInterruptores);
            Console.WriteLine("- Costo mano de obra: $" + manoDeObra);
            Console.WriteLine("- Costo total: $" + costoTotal);
        }



    }
}
