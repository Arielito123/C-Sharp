using System;

namespace Ejercicio10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Desarrollar un método que permita determinar si un número es par o impar.


            int numero;

            Console.WriteLine("Ingrese un numero");//leyenda de ingreso
            numero = int.Parse(Console.ReadLine());//parceo de numero

            if (Par(numero) == 0//llamamos a la funcion par
            {
                Console.WriteLine("Su Numero es par");//leyenda si es par
            }

            else
            {
                Console.WriteLine("Su Numero es Impar");//leyenda si es impar
             }


            Console.ReadKey();

        }













        static int Par(int Numero)//Funcion Par Por parametro
        {
            int Par;


            Par = Numero % 2;//decimos que par es igual a numero por modulo de 2

            return Par;//retornamos par

        }


    }
}
