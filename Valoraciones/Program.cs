using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto libro
            LibroValoraciones libro =new LibroValoraciones();

            //Asignar Valoraciones
            libro.AgregarValoraciones(5); //si es numero con decimales .> 3.5f
            libro.AgregarValoraciones(4);
            libro.AgregarValoraciones(3);
            libro.AgregarValoraciones(2);
            libro.AgregarValoraciones(1);
     
            // Publicar Valoraciones
            CalcularValoraciones publicar = libro.PublicarValoraciones();
            Console.WriteLine("El promedio de las valoraciones es : " + publicar.promedioValoraciones);
            Console.WriteLine("La valoración máxima es : " + publicar.valoracionMax);
            Console.WriteLine("La valoración mínima es : " + publicar.valoracionMin);
            Console.ReadLine();
            // valoracionMinima
            // ValoracionMaxima
            // promedioValoraciones
        }
    }
}
