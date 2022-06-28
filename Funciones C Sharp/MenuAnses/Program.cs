using System;
namespace MenuAnses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] Apellido = new string[10];//array 10 posiciones
            string[] Nombre = new string[10];//array 10 posiciones
            char[] Sexo = new char[10];//array 10 posiciones
            int [] Edad = new int[10];//array 10 posiciones
            double[] DNI = new double[10];//array 10 posiciones
            bool bandera = true;//variable bandera tipo booleana
            char   Menu='a';//nuestra variable menu
            string buscar;//para poder buscar apellido
            double buscarDni;//para poder buscar dni
            char Salir;//para poder crear una salida en nuestro menu

            for(int i = 0; i < 10; i++)//ciclo de repeticion para cargar datos
            {
                Console.WriteLine("Ingrese El Apellido"+" "+(i+1)+":");
                Apellido[i] = Console.ReadLine();
                Apellido[i]=Apellido[i].ToUpperInvariant();

                Console.WriteLine("Ingrese El Nombre"+" "+(i+1)+":");
                Nombre[i] = Console.ReadLine();

                Console.WriteLine("Ingrese EL Sexo f=femenino m=Masculino"+" "+(i+1)+":");
                Sexo [i] = char.Parse(Console.ReadLine());
                Sexo[i] = char.ToUpper(Sexo[i]);//convertimos la variable guarda en el vector a mayuscula

                while ((Sexo[i] != 'F')&& (Sexo[i] != 'M'))//validamos el seño
                {
                    Console.WriteLine("El sexo ingresado no se encuentra vuelva a ingresar f o m"+" "+(i+1)+":");
                    Sexo[i] = char.Parse(Console.ReadLine());
                    Sexo[i] = char.ToUpper(Sexo[i]);//volvemos a convertir la variable guardada a mayuscula
                }

                Console.WriteLine("Ingrese la Edad"+" "+(i+1)+":");
                Edad[i] = int.Parse(Console.ReadLine());

                if ((Edad[i] < 15)&& (Edad[i] > 76))//validamos la edad
                {
                    Console.WriteLine("Edad Incorrecta es de 15 a 75 años"+" "+(i+1)+":");
                    Edad[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese el DNi"+" "+(i+1)+":");
                DNI [i] = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");
            }

            //comenzamos a armar el menu despues de los datos cargados
            //-------------------------------------------------------

            while (Menu != 'D')
            {
                Console.WriteLine("Menu de Opciones");


                Console.WriteLine("A----->Listado Completo");
                Console.WriteLine("B----->Buscar POR Apellido");
                Console.WriteLine("C----->Buscar Por DNI");
                Console.WriteLine("D----->Salir");
                Menu = char.Parse(Console.ReadLine());
                Menu = char.ToUpper(Menu);
                while ((Menu != 'A') && (Menu != 'B') && (Menu != 'C')&& (Menu!='D'))
                {
                    Console.WriteLine("La Opcion es incorrecta vuelva a ingresar A,B,C o D");
                    Menu = char.Parse(Console.ReadLine());
                    Menu = char.ToUpper(Menu);
                }

                switch (Menu)
                {

                    case 'A':

                        for(int i = 0; i<10; i++)//Mostrara el listado completo cargado de los vectores anteriormente por el usuario
                        {
                            Console.WriteLine(Apellido[i]+" "+ Nombre[i]+" "+" Sexo: "+Sexo[i]+" "+" Edad: "+Edad[i] +" Años: "+" "+" DNI: "+DNI[i]+ "\n");

                        }

                        break;


                    case 'B':

                            Console.WriteLine("Porfavor Ingrese el Apellido Que desees Buscar");
                            buscar = Console.ReadLine();//parceamos la variable que buscara el apelledip
                            buscar = buscar.ToUpperInvariant();//convertimos la informacio puesta por el usuario a mayuscula

                            for(int i = 0; i < 10; i++)//ciclo de repeticion 
                            {
                            if (buscar == Apellido[i])//decimos si buscar es igual a apellido
                            {
                                bandera = false;//la bandera sera falsa entonces se cargaran los datos encontrados

                                Console.WriteLine(Apellido[i]+" "+Nombre[i]+" "+" Sexo "+Sexo[i]+" "+" Edad:"+Edad[i]+" Años "+""+" DNI: "+DNI[i]);
                            }
                        }

                        if (bandera == true)//si la bandera es verdadera no existe ese apellido
                        {
                            Console.WriteLine("No se encontro ese apellido");
                        } 

                        break;


                    case 'C':

                        Console.WriteLine("Ingrese el Dni De la persona que quiera buscar");
                        buscarDni = double.Parse(Console.ReadLine());//parceamos la variable que buscara el dni

                        for(int i = 0; i < 10; i++)
                        {
                            if (buscarDni == DNI[i])//si buscar dni es igual a dni
                            {
                                bandera = false;//la bandera ser falsa y se cargaran los datos encontrados
                                Console.WriteLine(Apellido[i] + " " + Nombre[i] + " " + " Sexo " + Sexo[i] + " " + " Edad:" + Edad[i] + " Años " + "" + " DNI: " + DNI[i]);
                            }
                        }

                        if (bandera == true)//si la bandera es verdadera ese dni no existe en esta lista
                        {
                            Console.WriteLine("Ese Dni No Se Encuenta en esta lista");
                        }

                        break;


                    case 'D':
                        Console.WriteLine("¿Desea salir? (S/N)");
                        Salir = char.Parse(Console.ReadLine());
                        Salir = char.ToUpper(Salir);
                        while (Salir != 'S' && Salir != 'N')
                        {
                            Console.WriteLine("Debe ingresar S = Si o N = No");
                            Salir = char.Parse(Console.ReadLine());
                            Salir = char.ToUpper(Salir);
                        }
                        if (Salir == 'S')
                        { Menu = 'D'; }
                        else { Menu = 'E'; }
                        break;

                }


            }


            Console.ReadKey();






        }
    }
}
