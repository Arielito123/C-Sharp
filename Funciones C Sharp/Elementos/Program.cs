using System;

namespace Elementos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Cargar números a un vector de enteros de 10 elementos e informar:
a) Promedio de los números positivos ingresados.
b) Sumatoria de los que se encuentran en las posiciones impares del vector.
c) El número mayor, el menor y la posición donde se encuentran*/


            double[] Numero = new double[10];// array de 10 posiciones

            float Prom = 0, SumaImpares = 0, SumaPositivo = 0;//3 variables de tipo float
            double Mayor = 1, Menor = 1000000;//le damos un valor a mayor y a menor para luego encontrar ese valor
            int posMa = 1, posMe = 1;


            for (int i = 0; i < 10; i++)// ciclo de repeticion para cargar datos por el usuario
            {
                Console.WriteLine("Ingrese un numero" + " " + (i + 1) + ":");
                Numero[i] = double.Parse(Console.ReadLine());
                Console.Clear();
                if (Numero[i] > 0)// si numero es mayor a 0
                {
                    SumaPositivo =(float)(SumaPositivo + Numero[i]);//suma guardara la suma + el numero tanta veces se repita el for
                    Prom = SumaPositivo / 10;//para luego hacer un proceso para sacar el promedio de esa suma
                }


                if (Numero[i] % 2 == 1)//si numero modulo de dos da como resto 1
                {
                    
                    SumaImpares = (float)(SumaImpares + Numero[i]);//solamente se sumaran los Impares
                }


                if (Numero[i] > Mayor)//numero > mayor
                {
                    Mayor = Numero[i];//entonces mayor guardara el numero
                    posMa = (i+1);//colocaremos nuestra posicion para saber en que posicion se hayo ese numero
                }


                if (Numero[i] < Menor)//numero<Menor
                {
                    Menor = Numero[i];//entonces menor guardara el valor de numero
                    posMe = (i+1);//pondremos una posicion para saber donde se encontro el menor
                }




            }


            Console.WriteLine("Lista de Numeros Ingresados en el vector"+ "\n");//leyenda para mostrar los datos ingresados del vector por el usuario

            for (int i = 0; i < 10; i++)//repetimos el ciclo
            {
                Console.Write("/"+Numero[i]);//mostramos los numeros dentro del vector numero
                
            }

            Console.WriteLine("\n" + "\n" + " Promedio de los numeros postivos ingresados " + Prom + "\n");//sacamos por pantalla el promedio solo de los positivos


            Console.WriteLine("Lista de numeros Impares"+ "\n");//leyenda para mostrar los impares

            for (int i = 0; i < 10; i++)//ciclo de repeticion
            {
                if (Numero[i] % 2 == 1)//si numero %2 tiene como resto 1
                {
                    Console.Write("/"+Numero[i]);//se imprimiran los numeros impares

                }

                
            }

            Console.WriteLine("\n"+ "\n" + " La suma de los impares es de: " + SumaImpares + "\n");//leyenda con la suma de los impares

            Console.Write(" El numero mas Alto fue " + Mayor);//leyenda mostrando el numero mayor

            if (posMa == 1)//si la posMa es igual a un numero entonces
            {
                Console.Write(" Se encuentra en la posicion 1 "+ "\n");// se imprimira la posicion en la que se encuentra
            }

            if (posMa == 2)
                
            {
                Console.Write(" Se encuentra en la posicion 2 "+ "\n");
            }

            if (posMa == 3)
            {
                Console.Write(" Se encuentra en la posicion 3 "+ "\n");
            }

            if (posMa ==4)
            {
                Console.Write(" Se encuentra en la posicion 4 "+ "\n");
            }

            if (posMa == 5)
            {

                Console.Write(" Se encuentra en la posicion 5 "+ "\n");


            }


            if (posMa == 6)
            {
                Console.Write(" Se encuentra en la posicion 6 "+ "\n");
            }


            if (posMa == 7)
            {
                Console.Write(" Se encuentra en la posicion 7 "+ "\n");
            }


            if (posMa == 8)
            {
                Console.Write(" Se encuentra en la posicion 8 "+ "\n");
            }



            if (posMa == 9)
            {
                Console.Write(" Se encuentra en la posicion 9 "+ "\n");
            }

            if (posMa == 10)
            {
                Console.Write(" Se encuenntra en la posicion 10 "+ "\n");
            }



            Console.Write("\n" + " El Numero Mas Bajo Fue de: " + Menor);//leyenda con el valor del numero mas bajo

            if (posMe == 1) //si la posMe es igual a un numero entonces
            {
                Console.Write( " Se encuentra en la posicion 1 ");// se imprimira la posicion del numero menor
            }

            if (posMe == 2)
            {
                Console.Write( "Se encuentra en la Posicion 2 ");
            }

            if (posMe == 3)
            {
                Console.Write( " Se encuentra en la Posicion 3 ");
            }

            if (posMe == 4)
            {
                Console.Write( " Se encuentra en la Posicion 4 ");
            }

            if (posMe == 5)
            {
                Console.Write( " Se encuentra en la Posicion 5 ");
            }

            if (posMe == 6)
            {
                Console.Write( " Se encuentra en la Posicion 6 ");
            }

            if (posMe == 7)
            {
                Console.Write( " Se encuentra en la Posicion 7 ");
            }

            if (posMe == 8)
            {
                Console.Write( " Se encuentra en la Posicion 8 ");
            }

            if (posMe == 9)
            {
                Console.Write( " Se encuentra en la Posicion 9 ");
            }

            if (posMe == 10)
            {
                Console.Write( " Se encuentra en la Posicion 10 ");
            }

           

            Console.ReadKey();


        }
    }
}
