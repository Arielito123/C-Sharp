using System;

namespace Ejercicio9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Programar un método que reciba 5 números y devuelva el valor del menor.

            double n1=1,Menor=1000000000;

           

           
            Menor = BuscarMenor(n1);//Buscamos el menor con nuestra funcion buscaMenor

            Console.WriteLine(" El Numero menor es " +Menor);//decimos que el numero es menor
        }



        static double BuscarMenor(double n1) //variable por parametro
        
        {
            double Menor=1000000000;//le damos un valor alto para luego buscar un valor menor

         
               
            for(double x = 1; x <= 5; x++) //ciclo de repeticion
            {
                Console.WriteLine("Ingrese 5 numeros");//leyenda
                n1 = double.Parse(Console.ReadLine());//parceo de numero

                if (n1 < Menor) //if diciendo si n1 es menor
                {
                    Menor = n1;//entonces menor sera igual n1
                }


            }



            return Menor;//Retornamos el valor Menor
        
        }





    }

    }


