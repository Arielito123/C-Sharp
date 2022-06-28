using System;

namespace Ejercicio1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        /*Escribir un programa que permita ingresar 10 números enteros a un vector e informarlos
separados por un espacio.*/


        double[] numero = new double[10];//una array de 10  pocisiones
        
        for (int i = 0; i < 10; i++)//ciclo de repeticion
        {
            Console.WriteLine("Ingrese 10 numeros"+(i+1));//leyenda de ingreso
            numero[i] = double.Parse(Console.ReadLine());//parseamos la array de numero


        }

        for(int i = 0; i < 10; i++)//otro ciclo de repeticion para mostrar los numeros
            {
                Console.Write(numero[i]+" ");//mostramos los numeros separados por un espacio
            }




        }
    }
}
