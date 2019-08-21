using System;
using System.Collections.Generic;
using System.Text;
using ConsolaFiguraGeometrica.Interface;

namespace ConsolaFiguraGeométrica.Modelo
{
    public class Triangulo : IFiguraGeometrica
    {
        private float bas;
        private float altura;
        private string nombre = "Triángulo";
        public Triangulo(float b, float h)
        {
            bas = b;
            altura = h;
        }
        public float calcularArea()
        {
            return (bas * altura) / 2;
        }

        public float calcularPerimetro()
        {
            return bas * 3;
        }

        public string obtenerNombre()
        {
            return nombre;
        }
    }
}
