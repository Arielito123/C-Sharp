using System;

namespace Ejercicio7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Escribir un programa que permita cargar el apellido, nombre y edad de 10 personas, al
finalizar, el usuario deberá ingresar un apellido a buscar en la lista, si dicho apellido se
encuentra informar los datos de la persona (apellido, nombre y edad). De lo contrario
informar la leyenda “El apellido no se encontró en la lista”.*/

            string[] Apellido = new string[10];//Array de 10 Posiciones
            string[] Nombre = new string[10];//Array de 10 Posiciones
            int[] Edad = new int [10];//Array de 10 Posiciones

            string Lista;//variable para luego buscar el appelido

            bool bandera = true;//una variable de tipo booleana en forma de bandera

            Console.WriteLine("Programas para cargar apellidos,Nombre y edad\n");//Leyenda con lo que hace el programa

            for (int i = 0; i < 2; i++)//Primer for para cargar los vectores
            {
                Console.WriteLine(" Cargue el Apellido " + " " + (i + 1) + ":");//leyenda para cargar el apellido
                Apellido[i] = Console.ReadLine();//parceamos el  vector Apellido [i]
                Console.WriteLine(" Cargue el Nombre " + " " + (i + 1) + ":");//leyenda para cargar el nombre
                Nombre[i] = Console.ReadLine();//Parceamos el vector Nombre[i]
                Console.WriteLine(" Cargue La Edad " + " " + (i + 1) + ":");//leyenda para cargar la edadher
                Edad [i] = int.Parse(Console.ReadLine());//parceamos el vector Edad[i]


            }

            Console.WriteLine("Escriba el apellido de la persona que quiera ver");//busca por apellido la persona que quieras ver su informacion

            Lista = Console.ReadLine();
            for (int i = 0; i <10;i++)//segundo for para mostrar las lista y otros procesos
            {


                if (Lista == Apellido[i])//si lista[i]es igual Apellido[i] entrara el if por verdadero
                {

                    bandera = false;//le decimos que bandera es falso entonces mostrara algo

                    Console.Write(Apellido[i]+" "+Nombre[i]+" "+Edad[i]+" Años "+ "\n");

                    
                }







            }

            if (bandera == true)//decimos si bandera es verdadero no se encontro apellido
            {
                Console.WriteLine("No existe ese apellido");
            }




            Console.ReadKey();

        }












        }
    }

