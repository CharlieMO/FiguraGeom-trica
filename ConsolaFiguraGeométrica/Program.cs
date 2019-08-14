using ConsolaFiguraGeometrica.Interface;
using System;

namespace ConsolaFiguraGeométrica
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void mostrarInformacion(IFiguraGeometrica figura)
        {
            Console.WriteLine($"Nombre : {figura.obtenerNombre()}");
            Console.WriteLine($"Area : {figura.calcularArea()}");
            Console.WriteLine($"Perimetro : {figura.calcularPerimetro()}");
        }
    }
}
