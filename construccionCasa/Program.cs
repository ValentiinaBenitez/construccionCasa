using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicohogar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LivingComedor livingComedor = new LivingComedor(5, 4, 6, "blanco", "ceramica de barro", 4);
            Cocina cocina = new Cocina(3, 4, 3, "blanco", "ceramica de barro", 4);
            Baño baño = new Baño(2, 3, 1, "blanco", "cemento pulido", 4);
            Dormitorio dormitorioUno = new Dormitorio(3, 3, 2, "blanco", "madera", 4);
            Dormitorio dormitorioDos = new Dormitorio(3, 3, 2, "blanco", "madera", 4);

            List<Estructura> habitaciones = new List<Estructura>
            {
                livingComedor, cocina, baño, dormitorioUno, dormitorioDos
            };

            string[] nombreDeHabitacion = { "- LIVING-COMEDOR -", "- COCINA -", "- BAÑO -", "- DORMITORIO UNO -", "- DORMITORIO DOS -" };

            string colorPared;
            string tipoPiso;

            Console.WriteLine("||||| Bienvenido a la construcción o remodelación de una casa :) |||||");
            Console.WriteLine("");
            Console.WriteLine("> Seleccione <");
            Console.WriteLine("1. Construir");
            Console.WriteLine("2. Remodelar");
            Console.WriteLine("3. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (opcion != 3)
            {
                if (opcion == 1)
                {
                    int x = 0;
                    foreach (var i in habitaciones)
                    {
                        Console.WriteLine(nombreDeHabitacion[x]);
                        x++;

                        Console.Write("Ancho: ");
                        int ancho = Convert.ToInt32(Console.ReadLine());
                        i.setAncho(ancho);

                        Console.Write("Largo: ");
                        int largo = Convert.ToInt32(Console.ReadLine());
                        i.setLargo(largo);

                        Console.Write("Cantidad de luces: ");
                        int cantidadLuces = Convert.ToInt32(Console.ReadLine());
                        i.setCantidadLuces(cantidadLuces);

                        Console.Write("Color de la pared: ");
                        colorPared = Console.ReadLine();
                        i.setColorPared(colorPared);

                        Console.Write("Tipo de piso: ");
                        tipoPiso = Console.ReadLine();
                        i.setTipoPiso(tipoPiso);

                        Console.Write("Altura: ");
                        int alto = Convert.ToInt32(Console.ReadLine());
                        i.setAlto(alto);

                        Console.Clear();
                    }

                    Console.WriteLine("Eliga una opción");
                    Console.WriteLine("1. Ordenar habitaciones");
                    Console.WriteLine("2. Ver que puedo hacer en las habitaciones");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    while (opcion != 3)
                    {
                        Console.Clear();
                        if (opcion == 1)
                        {
                            Console.WriteLine("-- LIVING-COMEDOR --");
                            livingComedor.ordenar();
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("-- COCINA --");
                            cocina.ordenar();
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("-- BAÑO --");
                            baño.ordenar();
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("-- DORMITORIOS --");
                            dormitorioUno.ordenar();
                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("-- LIVING-COMEDOR --");
                            livingComedor.acciones();
                            Console.WriteLine("");
                            Console.WriteLine("-- COCINA --");
                            cocina.acciones();
                            Console.WriteLine("");
                            Console.WriteLine("-- BAÑO --");
                            baño.acciones();
                            Console.WriteLine("");
                            Console.WriteLine("-- DORMITORIOS --");
                            dormitorioUno.acciones();
                        }
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Eliga otra opción");
                        Console.WriteLine("1. Ordenar habitaciones");
                        Console.WriteLine("2. Ver que puedo hacer en las habitaciones");
                        Console.WriteLine("3. Siguiente");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        
                    }

                    Console.Clear();

                    Console.WriteLine("*** Implemente una mejora ***");
                    Console.WriteLine("1. Living-Comedor");
                    Console.WriteLine("2. Cocina");
                    Console.WriteLine("3. Baño");
                    Console.WriteLine("4. Dormitorio");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    while (opcion != 5)
                    {
                        if (opcion == 1)
                        {
                            livingComedor.mejorarEstructura(livingComedor);
                        }
                        else if (opcion == 2)
                        {
                            cocina.mejorarEstructura(cocina);
                        }
                        else if (opcion == 3)
                        {
                            baño.mejorarEstructura(baño);
                        }
                        else if (opcion == 4)
                        {
                            dormitorioUno.mejorarEstructura(dormitorioUno);
                            Console.WriteLine("* Valor por dormitorio *");
                        }

                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("*** Implemente otra mejora ***");
                        Console.WriteLine("1. Living-Comedor");
                        Console.WriteLine("2. Cocina");
                        Console.WriteLine("3. Baño");
                        Console.WriteLine("4. Dormitorio");
                        Console.WriteLine("5. Siguiente");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }
                }

                else if (opcion == 2)
                {
                    Console.WriteLine("El living-comedor tiene pisos de " + livingComedor.getTipoPiso() + " y el color de las paredes es " + livingComedor.getColorPared() + ".");
                    Console.WriteLine("La cocina tiene pisos de " + cocina.getTipoPiso() + " y el color de las paredes es " + cocina.getColorPared() + ".");
                    Console.WriteLine("El baño tiene pisos de " + baño.getTipoPiso() + " y el color de las paredes es " + baño.getColorPared() + ".");
                    Console.WriteLine("Un dormitorio tiene pisos de " + dormitorioUno.getTipoPiso() + " y el color de las paredes es " + dormitorioUno.getColorPared() + ".");
                    Console.WriteLine("El otro dormitorio tiene pisos de " + dormitorioDos.getTipoPiso() + " y el color de las paredes es " + dormitorioDos.getColorPared() + ".");
                    Console.WriteLine("");
                    Console.WriteLine("||||| Eliga una opción |||||");
                    Console.WriteLine("1. Cambiar pisos");
                    Console.WriteLine("2. Pintar pared");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (opcion == 1)
                    {
                        Console.WriteLine("PISO DEL LIVING-COMEDOR:");
                        Console.Write("Tipo: ");
                        tipoPiso = Console.ReadLine();
                        livingComedor.setTipoPiso(tipoPiso);
                        livingComedor.cambiarPisos(livingComedor);
                        Console.WriteLine("");
                        Console.WriteLine("PISO DE LA COCINA:");
                        Console.Write("Tipo: ");
                        tipoPiso = Console.ReadLine();
                        cocina.setTipoPiso(tipoPiso);
                        cocina.cambiarPisos(cocina);
                        Console.WriteLine("");
                        Console.WriteLine("PISO DEL BAÑO");
                        Console.Write("Tipo: ");
                        tipoPiso = Console.ReadLine();
                        baño.setTipoPiso(tipoPiso);
                        baño.cambiarPisos(baño);
                        Console.WriteLine("");
                        Console.WriteLine("PISO DEL DORMITORIO");
                        Console.Write("Tipo: ");
                        tipoPiso = Console.ReadLine();
                        dormitorioUno.setTipoPiso(tipoPiso);
                        dormitorioDos.setTipoPiso(tipoPiso);
                        dormitorioUno.cambiarPisos(dormitorioUno);
                        Console.WriteLine("* Valor por dormitorio *");
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("PAREDES DEL LIVING-COMEDOR");
                        Console.Write("Color: ");
                        colorPared = Console.ReadLine();
                        livingComedor.setColorPared(colorPared);
                        livingComedor.pintarPared(livingComedor);
                        Console.WriteLine("");
                        Console.WriteLine("PAREDES DE LA COCINA");
                        Console.Write("Color: ");
                        colorPared = Console.ReadLine();
                        cocina.setColorPared(colorPared);
                        cocina.pintarPared(cocina);
                        Console.WriteLine("");
                        Console.WriteLine("PAREDES DEL BAÑO");
                        Console.Write("Color: ");
                        colorPared = Console.ReadLine();
                        baño.setColorPared(colorPared);
                        baño.pintarPared(baño);
                        Console.WriteLine("");
                        Console.WriteLine("PAREDES DEL DORMITORIO");
                        Console.Write("Color: ");
                        colorPared = Console.ReadLine();
                        dormitorioUno.setColorPared(colorPared);
                        dormitorioDos.setColorPared(colorPared);
                        dormitorioUno.pintarPared(dormitorioUno);
                        Console.WriteLine("* Valor por dormitorio *");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    
                }

                Console.WriteLine("> Seleccione <");
                Console.WriteLine("1. Construir");
                Console.WriteLine("2. Remodelar");
                Console.WriteLine("3. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }














}
