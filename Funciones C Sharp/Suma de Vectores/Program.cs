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

            int[] A = new int[5];//Array de 5 pocisiones
            int[] B = new int[5];//Array de 5 pocisiones
            int[] C = new int[5];//Array de 5 pocisiones



            for (int i = 0; i < 5; i++)//ciclo de carga de datos
            {
                Console.WriteLine("Ingrese 5 elementos o numeros del vector A");
                A [i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese 5 elementos o numeros del vector B");
                B[i] = int.Parse(Console.ReadLine());

                C[i] = A[i] + B[i];//El vector c tendra el valor de la array A + B 

            }


            
                for(int i = 0; i < 5; i++)//ciclo de repeticion para mostrar la suma del vector c
            {
                Console.WriteLine(C[i]);//mostramo el vector c;
            }
           

            










        }
    }
}
