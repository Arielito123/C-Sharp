using System;

namespace Ejercicio6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Programar un método que reciba dos números enteros por valor, inicio y fin y muestre
 por pantalla los números pares desde inicio hasta fin.*/

            double n1, n2;

            Console.WriteLine("PROGRAMA PARA MOSTRAR NUMEROS DE INICIO A FIN ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Ingrese dos numeros");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            pares(n1, n2);//Llamamos a la funcion Pares que nos mostrara los pares entre n1 y n2

            Console.ReadKey();

        }




        static double pares (double n1,double n2)// funcion para mostrar los pares
        {
            double result = 0;
            for (double i = n1; i <= n2; i=i + 2)//ciclo de repeticion que inicia en n1 y termina en n2
            {
                if ((i % 2) == 0)//le decimo si i modulo de 2 es igual a 0
                {
                    Console.Write(i+"-");//imprimira los numeros separados de un guion en forma de pares
                    result = i;//retornamos i
                }

                if ((i % 2)!= 0)//si i modulo de 2 es distinto de 0 nos mostrara los pares  separando los impares ejemplo si iniciamos en 101 y terminamos en 301 nos mostrara a partir del 102
                {
                    i++;//incrementamos la vairable
                    Console.Write(i+"-");//imprimira los numeros separados de un guion en forma de pares
                    result = i;//retornamos i
                }
            }

            return result;
        }








    }
}
