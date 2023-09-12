using System;

namespace program
{
    public class program
    {
        public static void Main(string[] args)
        {

           bool seguir = true;
            while(seguir) 
            { 
            Console.Write("MENU\n");
            Console.Write("1.Recibir mensaje de bienvenida\n");
            Console.Write("2.Saber si es Mayor/Menor de Edad\n");
            Console.Write("3.Saber el término Enésimo (n) <---> Sucesión de Fibonacci\n");
            Console.Write("4.Salir del programa\n\n");

            Console.Write("Seleccione la opcion deseada: ");
            int opc = Convert.ToInt32(Console.ReadLine());


                switch (opc)
                {

                    case 1:

                        Console.Write("Digite su nombre: ");
                        string name = Console.ReadLine();
                        string po = name;
                        if (name == po)
                        {
                            Console.Write("Hola" + " " + name + " " + "Bienvenido!!\n\n");
                        }
                        break;
                    case 2:
                        int age = 0;
                        try
                        {
                            Console.Write("Digite su Edad: ");
                            age = Convert.ToInt32(Console.ReadLine());
                            if (age < 18)
                            {
                                Console.Write("Es Menor de edad\n");
                            }
                            else if (age > 18)
                            {
                                Console.Write("Es Mayor de edad\n");
                            }


                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.Message + "\n\n");
                            Console.Write("Por favor digitar la opcion correcta");
                            Thread.Sleep(3000);
                            Console.Clear();


                            Console.Write("Digite su Edad: ");
                            age = Convert.ToInt32(Console.ReadLine());

                            if (age < 18)
                            {
                                Console.Write("Es Menor de edad");
                            }
                            else if (age > 18)
                            {
                                Console.Write("Es Mayor de edad");
                            }
                        }
                        Console.ReadKey();

                        break;
                    case 3:
                        try
                        {

                            Console.Write("Digite un numero: ");
                            int n = Convert.ToInt32(Console.ReadLine());

                            int c1 = 0, c2 = 1, c3;

                            for (int i = 0; i <= n; i++)
                            {
                                if (i <= 1)
                                {
                                    c3 = i;
                                }
                                else
                                {
                                    c3 = c1 + c2;
                                    c1 = c2;
                                    c2 = c3;

                                }
                                Console.Write(c3 + ",");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.Message + "\n\n");
                            Console.Write("Por favor digitar la opcion correcta");
                            Thread.Sleep(3000);
                            Console.Clear();

                            Console.Write("Digite un numero: ");
                            int n = Convert.ToInt32(Console.ReadLine());

                            int c1 = 0, c2 = 1, c3;

                            for (int i = 0; i <= n; i++)
                            {
                                if (i <= 1)
                                {
                                    c3 = i;
                                }
                                else
                                {
                                    c3 = c1 + c2;
                                    c1 = c2;
                                    c2 = c3;

                                }
                                Console.Write(c3 + ",");
                            }
                        }
                        break;
                    case 4:
                        Console.Write("¿Desea salir del programa? s/n?\n\n");
                        string opc2 = Console.ReadLine();
                     
                        if ( opc2 == "s")
                        {
                            seguir = false;
                        }
                        else { 
                            seguir = true;
                        } 
                        break;
                    default:
                        Console.Write("Usted ha ingresado la opcion incorrecta");
                        break;
                        
                                          
                
               }
         
              
            }

        }

    }
}
