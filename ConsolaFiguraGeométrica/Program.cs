using ConsolaFiguraGeometrica.Interface;
using ConsolaFiguraGeométrica.Modelo;
using System;

namespace ConsolaFiguraGeométrica
{
    class Program
    {
        static void Main(string[] args)
        {
            var cuadrado = new Cuadrado(5);
            mostrarInformacion(cuadrado);
            Console.ReadKey();
            var t = new Triangulo(5, 10);
            mostrarInformacion(t);
            Console.ReadKey();

        }

        static void mostrarInformacion(IFiguraGeometrica figura)
        {
            Console.WriteLine($"Nombre : {figura.obtenerNombre()}");
            Console.WriteLine($"Area : {figura.calcularArea()}");
            Console.WriteLine($"Perimetro : {figura.calcularPerimetro()}");
        }
    }
}
