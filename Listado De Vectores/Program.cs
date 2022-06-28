using System;

namespace Ejercicio6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Se ingresan el nombre y la edad de 5 personas, al finalizar informar el listado ingresado.

            string[] Nombre = new string[5];//Array de 5 posiciones
            int[] Edad = new int[5];//Array de 5 posiciones


            for (int i = 0; i < 5; i++)//ciclo para cargar los vectores
            {
                Console.WriteLine("Ingrese 5 nombres del Vector"+(i+1));
                Nombre[i] = Console.ReadLine();

                Console.WriteLine("Ingrese 5 Edades del vector"+(i+1));
                Edad[i] = int.Parse(Console.ReadLine());
            }

            
            for(int i = 0; i < 5; i++)// ciclo para mostrar la informacion guardada en los vectores
            {
                Console.Write(" Nombre: "+ Nombre[i]);
                Console.WriteLine("  "+Edad[i]   + " Años ");

            }

            Console.ReadKey();
        }
    }
}
