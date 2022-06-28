using System;

namespace Ejercicio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Dados dos vectores A y B de 5 elementos cada uno ingresados por el usuario se pide
 generar el vector C, también de 5 elementos, donde cada posición de dicho vector
 contendrá la sumatoria de las mismas posiciones de los vectores A y B. Luego informar
 el vector C.*/

            int[] A = new int[5];//array de 5 posiciones
            int[] B = new int[5];//array de 5 posiciones
            int[] C = new int[5];//array de 5 posiciones
            int[] D = new int[5];//array de 5 posiciones


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese 5 elementos o numeros del vector A");
                A[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese 5 elementos o numeros del vector B");
                B[i] = int.Parse(Console.ReadLine());

                C[i] = A[i] + B[i];//suma de los vectores a y b

            }


            int x = 4;//inicialisamos x en 4
            for (int i = 0; i < 5; i++)//ciclo de repeticion
            {
                D[i] = A[i] + B[x];//decimos que el array D tendra la suma de a en la posicion 1 con b en la posicion 4 y asi susecivamente
            }


            Console.WriteLine("Suma de los vectores A y B");
            for (int i = 0; i < 5; i++)//ciclo para mostrar la array c
            {
                Console.WriteLine(C[i]);
            }


            Console.WriteLine("Sumatoria de la poscion 1 del vector a con la ultima del b y asi susecivamente");

            for (int i = 0; i < 5; i++)//ciclo para mostrar la array Do
            {
                Console.WriteLine(D[i]);
            }

            Console.ReadKey();












        }
    }
}
