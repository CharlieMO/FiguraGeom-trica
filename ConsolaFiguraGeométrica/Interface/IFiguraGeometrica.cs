using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolaFiguraGeometrica.Interface
{
    public interface IFiguraGeometrica
    {
        float calcularArea();
        float calcularPerimetro();
        string obtenerNombre();
    }
}
