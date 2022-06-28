using System;

namespace Ejercicio11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //programa para determinar si un numero es primo o no

            int numero, cont = 0;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            cont = Primo(numero);//generamos la funcion primo diciendole que cont es igual a primo (numero)

            if (cont > 0)//si contador es mayor a 0
            {
                Console.WriteLine("Es Primo");//entonces es primo
            }

            else
            {
                Console.WriteLine("No Es Primo");// si no no lo es
            }

            Console.ReadKey();
        }




        

        static int Primo(int numero)//Metodo de tipo parametro
        {
            int cont = 0;

            for(int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)//si numero se divide por el mismo numero y el resto es igual a 0
                {
                    cont++;// se agrega un contador
                }
            }

            if (cont == 2)//si contador es igual a 2
            {
                return 1;// retornamos un 1
            }

            return -1;// si no es igual retornamos un menos 1
        }


    }
}
