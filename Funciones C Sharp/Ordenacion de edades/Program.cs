using System;

namespace Ejercicio10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Se ingresa la edad y el sexo (F=femenino, M=masculino), de 10 personas (validar todo).
Al finalizar los ingresos se pide informar un listados completo ordenado por edad de
menor a mayor.*/

            int[] Edad = new int[10];//Array de 10  posiciones
            char[] Sexo = new char[10];//Array de 10  posiciones
            int aux=0;//variable auxiliar que nos ayudara a guardar dato

            for (int i = 0; i < 10; i++)//ciclo de repeticion para cargar datos
            {
                Console.WriteLine(" Ingrese la edad de la persona " + (i + 1) + ":");
                Edad[i] = int.Parse(Console.ReadLine());


               while ((Edad[i] < 1)&& (Edad[i] > 104))//validamos la edad para que no se pueda poner menos de 1 o mas de 104
                {
                    Console.WriteLine("No cumple los párametros de edad de 1 a 104 años vuelva a ingresar"+(i+1)+":");
                    Edad[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(" Ingrese el sexo de la persona M= Masculino F= Femenino " + (i + 1) + ":");
                Sexo[i] = char.Parse(Console.ReadLine());
                Sexo[i] = char.ToUpper(Sexo[i]);//convertimos la letra guardada en el vector a mayuscula

                while ((Sexo[i] != 'M')&& (Sexo[i] != 'F'))//validamos el sexo para que solo pueda poner F o M
                {
                    Console.WriteLine("El Sexo ingresado no esta en los parametros M o F vuelva a ingresar"+(i+1)+":");
                    Sexo[i] = char.Parse(Console.ReadLine());
                    Sexo[i] = char.ToUpper(Sexo[i]);//lo volvemos a pasar a mayuscula

                }


            }

            for (int k = 9; k >=0; k--)//usamos el primer ciclo de repeticion para ayudar al segundo
            {
                for(int i = 0; i < k; i++)//segundo decimo que i empiece en cero perotermine en k
                {
                    if (Edad[i] > Edad[i + 1])//decimo si edad i es mayor a edad i+1
                    {
                        aux = Edad[i];//se guardara este proceso
                        Edad[i] = Edad[i + 1];//se hara este proceso
                        Edad[i + 1] = aux;//terminara con este proceso
                    }
                }
            }

            for(int i = 0; i <10; i++)//mostramos datos por pantalla
            {
                Console.WriteLine("edad de menor a mayor"+" "+(i+1)+":" +" Edad: "+Edad[i]+"sexo:"+" "+Sexo[i]);
            }
        }
    }
}
