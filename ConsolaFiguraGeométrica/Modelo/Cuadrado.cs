using System;
using System.Collections.Generic;
using System.Text;
using ConsolaFiguraGeometrica.Interface;

namespace ConsolaFiguraGeométrica.Modelo
{
    public class Cuadrado : IFiguraGeometrica
    {
        private float _lado;
        private string Nombre = "Cuadrado";
        public Cuadrado(float lado)
        {
            _lado = lado;
        }

        public float calcularArea()
        {
            return _lado * _lado;
        }

        public float calcularPerimetro()
        {
            return _lado * 4;
        }

        public string obtenerNombre()
        {
            return Nombre;
        }
    }
}
