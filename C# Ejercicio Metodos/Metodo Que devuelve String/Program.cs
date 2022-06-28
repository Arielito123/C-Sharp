using System;

namespace Ejercicio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Escribir un método que reciba un entero validado entre 1 y 12 y devuelva un string
 correspondiente al mes del año que representa dicho número.*/

            int numero;
            string mes;

            while(true){

                Console.WriteLine("Ingrese Un Numero");//leyenda de ingreso
            numero = int.Parse(Console.ReadLine());//parceo

            while ((numero <= 0) || (numero >= 13))//valido que el usuario no ingrese menos de 0 ni mas de 12
            {
                Console.WriteLine("El Numero Ingresado no esta en el Parametro Vuelva a ingresar");//le pido que vuelva a ingresar los datos
                numero = int.Parse(Console.ReadLine());//parceo nuevamente
            }

            mes = Meses(numero);//llamo la funcion Meses;

        }
        }

        static string Meses(int numero)//funcion de tipo parametro paso un entero me devuelve un string
        {
            string mes="";


          

            switch (numero)// todos los casos del 1 al 12 con su respectivo Mes
            {
                case 1: Console.WriteLine("ENERO");
                    break;


                case 2:
                    Console.WriteLine("FEBRERO");
                    break;

                case 3:
                    Console.WriteLine("MARZO");
                    break;

                case 4: Console.WriteLine("ABRIL");
                    break;

                case 5:
                    Console.WriteLine("MAYO");
                    break;

                case 6: Console.WriteLine("Junio");
                    break;

                case 7: Console.WriteLine("JULIO");
                    break;

                case 8: Console.WriteLine("AGOSTO");
                    break;

                case 9: Console.WriteLine("SEPTIEMBRE");
                    break;

                case 10: Console.WriteLine("OCTUBRE");
                    break;

                case 11: Console.WriteLine("NOVIEMBRE");
                    break;

                case 12: Console.WriteLine("DICIEMBRE");
                    break;


            }

            return mes;

        }



    }



}





