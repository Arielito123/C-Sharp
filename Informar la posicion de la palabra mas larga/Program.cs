using System;

namespace Ejercicio9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Se ingresan 5 palabras a un vector de string se pide informar la posición de la palabra
con más letras*/

            string[] Palabra = new string[5];//vector de tipo string
            int pos = 1,mayor=0;//dos varibles de tipo int
            int[] numero =new int[5];//vector de tipo int



            for (int i = 0; i < Palabra.Length; i++)
            {
                Console.WriteLine("Ingrese una palabra");
                Palabra[i] = Console.ReadLine();

                numero[i] = Palabra[i].Length;//usamos una variable numero para guardar el tamaño de la palabra

                if (numero[i] > mayor)//usamos if  para buscar la palabra mayor
                {
                    mayor = numero[i];//proceso para detectar el numero mayor
                    pos = (i+1);//buscamos pocicion i+1
                }
            }
            Console.WriteLine("La palabra mas mas larga se encuentra en la pocision"+pos);

        }
    }
}
