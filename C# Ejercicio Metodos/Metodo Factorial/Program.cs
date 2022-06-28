using System;

namespace Ejercicio5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Programar un método que reciba un número por valor y devuelva el factorial del mismo.*/

            double numero,factorial;//generamos las variables
            Console.WriteLine("Ingrese Un Numero A Factorear");//leyenda

            numero = double.Parse(Console.ReadLine());//parceamos

            factorial = Factorial(numero);//llamamos a la funcion factorial
            Console.WriteLine(" El fACTORIAL DEL NUMERO ES "+factorial);//mostramos por pantalla el factorial

            Console.ReadKey();

        }


        static double Factorial(double n1)//Funcion Para Factorial Un Numero
        {
            double fac = 1;//generamos una vairable fac y la igualamos a 1

            for (int i = 1; i <= n1; i++)//ciclo de repeticion para sacar el factorial
            {
                fac = fac * n1;//decimos que fac es igual a fac *numero lo que hara que se multiplique de atras para delante hasta llegar a 1

            }

            return fac;//retornamos fac

        }
    }
}
