using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.calcule_e_indique_si_un_año_es_biciesto_o_no
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int año;

            Console.WriteLine("Ingrese un año para verificar si es bisiesto:");
            año = Convert.ToInt32(Console.ReadLine());

            if (EsBisiesto(año))//la bifurcación condicional. El cuerpo de una instrucción if se ejecuta si el valor de la expresión es distinto de cero.
            {
                Console.WriteLine("{0} es un año bisiesto.", año);
            }
            else//Es usada para ejecutar una instrucción o bloque de instrucciones solo si una condición es cumplida
            {
                Console.WriteLine("{0} no es un año bisiesto.", año);
            }

            Console.ReadLine();
        }

        static bool EsBisiesto(int año)// Este método analiza el argumento de cadena como un booleano.
        {
            // Un año es bisiesto si es divisible por 4, pero no si es divisible por 100,
            // a menos que también sea divisible por 400.
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }
    }
}