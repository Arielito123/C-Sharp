using System;

namespace funcioncalculadora
{
    class MainClass
    {
        private static char salir;

        public static void Main(string[] args)
        {

            Menu();
           


            Console.ReadKey();
        }


        static void Menu()
        {
            int opc=0;
            char Salir;

           
            while(opc!=7)
            {

             
            Console.WriteLine("1.Sumar");//sacamos la ley
            Console.WriteLine("2.Restar");//sacamos la leyenda con instruccion resta
            Console.WriteLine("3.Multiplicar");//sacamos la leyenda con instruccion Multiplicar
            Console.WriteLine("4.Dividir");//sacamos la leyenda con instruccion dividir
            Console.WriteLine("5.Para Sacar la Potencia de un numero");//sacamos la leyenda con instruccion potencia
            Console.WriteLine("6.Para sacar Raiz de un numero");//sacamos la leyenda con instruccion 
            Console.WriteLine("7.Salir");//sacamos la leyenda con instruccion salir
        
            opc = int.Parse(Console.ReadLine());//guardamos la variable opc como entero para poder usar switch
                Console.Clear();

            switch (opc)
            {
                case 1:
                    Suma();//metodo Suma

                    break;

                case 2: Resta();//metodo Resta
                    break;

                case 3: Multiplicar();//Metodo Multiplicacion
                    break;


                case 4: Dividir();//Metodo Dividir
                    break;

                    case 5: Potencia();//Metodo Potencia
                    break;

                case 6: Raiz();//metodo Raiz
                    break;

                case 7:
                    Console.WriteLine("¿Desea salir? (S/N)");
                    salir = char.Parse(Console.ReadLine());
                    salir = char.ToUpper(salir);
                    while (salir != 'S' && salir != 'N')
                    {
                        Console.WriteLine("Debe ingresar S = Si o N = No");
                        salir = char.Parse(Console.ReadLine());
                        salir = char.ToUpper(salir);
                    }
                    if (salir == 'S')
                    { opc = 7; }
                    else { opc = 8; }
                    break;


            }
            }
        }



        static  void Suma()// metodo suma
        {
            int n1, n2, suma = 0;
            Console.WriteLine(" Ingrese el primer numero ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese el segundo Numero ");
            n2 = int.Parse(Console.ReadLine());

            suma = n1+n2;

            Console.WriteLine(" La suma es " + suma);


        }


        static void Resta()//Metodo Resta
        {
            int n1, n2, Resta = 0;
            Console.WriteLine(" Ingrese el primer numero ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese el segundo Numero ");
            n2 = int.Parse(Console.ReadLine());

            Resta = n1 - n2;

            Console.WriteLine(" La Resta es " + Resta);

        }


        static void Multiplicar()//Metodo Multiplciar
        {
            int n1, n2, Multiplicacion = 0;
            Console.WriteLine(" Ingrese el primer numero ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese el segundo Numero ");
            n2 = int.Parse(Console.ReadLine());

            Multiplicacion = n1 * n2;

            Console.WriteLine(" La MultiPlicacion de sus dos numeros " + Multiplicacion);

        }

      
        static void Dividir()//Metodo Dividir
        {
            int n1, n2;
            float Dividir;
            Console.WriteLine(" Ingrese el primer numero ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese el segundo Numero ");
            n2 = int.Parse(Console.ReadLine());


            while (n2 == 0)//validamos que si el segundo numero es cero se vuelva a repetir  el ingreso
            {

                Console.WriteLine("el segundo numero no es valido vuelva a ingresarlo");/*sacamos una leyenda diciendo q el segundo numero no es validor
                                                                                                     y que vuelva ingresarlo*/
                n2 = int.Parse(Console.ReadLine());//guardamos la variable de tipo float


            }



            Dividir = n1 / n2;

            Console.WriteLine(" La Division de sus dos numeros " + Dividir);
            
        }



        static void Potencia()//metodo potencia
        {
            int n1, n2;
            double Potencia = 0;
            Console.WriteLine(" Ingrese La base ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese El exponente");
            n2 = int.Parse(Console.ReadLine());

            Potencia = Math.Pow(n1, n2);//metodo pow

            Console.WriteLine("la potencia de sus dos numeros son " + Potencia);
        }



        static void Raiz()//metodo raiz
        {
            int n1;
            double Raiz = 0;
            Console.WriteLine("Para Sacar raiz Cuadrada");
            Console.WriteLine(" Ingre la base ");
            n1 = int.Parse(Console.ReadLine());

            Raiz = Math.Sqrt(n1);//metodo sqrt 

            Console.WriteLine(" La raiz del numero selecionado es "+ Raiz);

        }



      

    }
}
