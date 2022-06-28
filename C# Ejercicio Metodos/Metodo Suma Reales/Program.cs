using System;

namespace Ejercicio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Desarrollar un método que reciba los valores de 2 números reales y devuelva la
 sumatoria de los mismos.*/

            float Num1, Num2, Suma = 0;

            Console.WriteLine("Ingrese dos Numeros A sumar");// leyenda
            Num1 = float.Parse(Console.ReadLine());//parceo n1
            Num2 = float.Parse(Console.ReadLine());//parceo n2

            Suma = SUMAR(Num1, Num2);//llamo a la funcion Sumar

            Console.WriteLine(" La Suma De Sus Dos Numeros son " + Suma);//muestro por pantalla

            Console.ReadKey();


        }




        static float SUMAR (float N1,float N2)//funcion sumar de tipos reales
        {
            float suma;

            suma = N1 + N2;//n1+ n2

            return suma;// Retorno Suma

        }





    }
}
