using System;
using System.Collections.Generic;
using System.Text;

namespace LABRADTAREA.Controllers
{
    public class Calculadora
    {
        public double Suma(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Resta(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Divicion(double numero1, double numero2)
        {
            return numero1 / numero2;
        }

        public double Multiplicacion(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
    }
}
