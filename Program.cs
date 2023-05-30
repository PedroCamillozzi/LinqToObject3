using LinqToObject3.Clases;
using System;
using System.Collections;
using System.Linq;

namespace LinqToObject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ciudades = new ArrayList();

            ciudades.Add(new Ciudad("Rosario", 2000));
            ciudades.Add(new Ciudad("Firmat", 2630));
            ciudades.Add(new Ciudad("Cañada Del Ucle", 2635));
            ciudades.Add(new Ciudad("Casilda", 2170));
            ciudades.Add(new Ciudad("Venado Tuerto", 2600));
            ciudades.Add(new Ciudad("Chañar Ladeado", 2643));
            ciudades.Add(new Ciudad("Santa Fe", 3000));
            ciudades.Add(new Ciudad("Los Quirquincho", 2637));
            ciudades.Add(new Ciudad("Berabevu", 2639));
            ciudades.Add(new Ciudad("Villada", 2173));

            Console.WriteLine("Ingrese la ciudad o como inicia");
            string rta = Console.ReadLine().ToLower();

            var cFiltradas = ciudades.Cast<Ciudad>().Where(c => c.Nombre.ToLower().StartsWith(rta)).Select(c => new { Nombre = c.Nombre, CodigoPostal = c.CodigoPostal });

            if (cFiltradas.Count() == 0)
            {
                Console.WriteLine("No hay ciudades cargadas que empiecen asi");

            }
            else
            {
                foreach (var c in cFiltradas)
                {
                    Console.WriteLine($"{c.Nombre}  {c.CodigoPostal}");
                }
            }
        }
    }
}