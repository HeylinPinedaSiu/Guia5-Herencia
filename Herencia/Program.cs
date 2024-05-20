using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {

        public static void Main(String[]args)
        {

            //Creacion de arreglo con un espacio de memoria  para 5 elementos

            TelefonoInteligente[] registro_Inteligente = new TelefonoInteligente[5];
            TelefonoBasico[] registro_Basico = new TelefonoBasico[5];

            //creamos la instancia de la clase telefono inteligente y telefono basico
            TelefonoInteligente inteligente = new TelefonoInteligente();
            TelefonoBasico basic = new TelefonoBasico();
            int opcion = 0;
            int intentos = 0;
           
            do
            {
               while (intentos < 3)
               {
                Console.WriteLine("  ~~~~ ▒▒▒▒▒▒▒▒▒▒▒▒Bienvenidos al Sistema de Gestion para Inventario de una Tienda de Telefono▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ~~~~");
                Console.WriteLine("");            
                Console.WriteLine("             *****     Opciones      *****      ");
                Console.WriteLine("   1.         Registrar un telefono             ");
                Console.WriteLine("   2.         Mostrar telefonos registrados     ");
                Console.WriteLine("   3.         Stock de un telefono              ");
                Console.WriteLine("   4.         Salir                             ");
                Console.WriteLine();

             try
             {

             Console.Write("Ingrese la opcion que desea: ");
              opcion = Convert.ToInt32(Console.ReadLine());

             switch (opcion)
             {

                case 1:               
                string tipoTelefono;
                Console.WriteLine("¿Que tipo de telefono desea registrar?");
                Console.Write($" Telefono Inteligente ");
                Console.Write($"Telefono Basico ");
                tipoTelefono = Console.ReadLine();
                Console.WriteLine();

                                if (tipoTelefono == "Telefono Inteligente")
                                {
                                    for (int i = 0; i < registro_Inteligente.Length; i++)
                                    {                                       
                                        Console.WriteLine("Telefono" + "  " + (1 + i));
                                        Console.WriteLine("");

                                        registro_Inteligente[i] = new TelefonoInteligente();
                                        registro_Inteligente[i].RegistrarInteligente();
                                        Console.WriteLine("");                              
                                    }
                                }
                                else if (tipoTelefono == "Telefono Basico")
                                {

                                    //Este for permite rrecorer todo el vector de los telefonos basicos

                                    for (int i = 0; i < registro_Basico.Length; i++)
                                    {                                      
                                        Console.WriteLine("Telefono" + "  " + (1 + i));                                        
                                        registro_Basico[i] = new TelefonoBasico();
                                        registro_Basico[i].RegistrarBasico();                                      
                                      
                                    }

                                }

                                break;

                            case 2:       
                                Console.WriteLine("Ha eligido mostrar los telefonos");    
                                Console.WriteLine();
                                Console.WriteLine("¿Que tipo de telefono desea mostrar?");
                                Console.Write($" Telefono Inteligente ");
                                Console.Write($"Telefono Basico ");
                                tipoTelefono = Console.ReadLine();                

                                if (tipoTelefono == "Telefono Inteligente")
                                {                                  
                                    Console.WriteLine("TELEFONOS INTELIGENTES");
                                    Console.WriteLine();

                                    for (int i = 0; i < registro_Inteligente.Length; i++)
                                    {

                                        Console.WriteLine("Telefono # : " + (i + 1));
                                        Console.WriteLine();

                                        registro_Inteligente[i].MostrarInformacionInteligente(); 
                                    }


                                }
                                else if (tipoTelefono == "Telefono Basico")
                                {                 
                                    Console.WriteLine("TELEFONOS BASICOS");
                                    for (int i = 0; i < registro_Basico.Length; i++)
                                    {

                                        Console.WriteLine("Telefono # : " + (i + 1));
                                        Console.WriteLine();

                                        registro_Basico[i].MostrarInformacionBasico();                                                         
                                    }
                                }
                                break;

                            case 3:             
                                Console.WriteLine("Ha eligido el STOCK de un telefono");                                                  
                                Console.WriteLine("¿Que tipo de telefono desea consultar?");
                                Console.Write($" Telefono Inteligente");
                                Console.Write($"Telefono Basico");
                                tipoTelefono = Console.ReadLine();
                                Console.WriteLine("");

                                Console.Write("Ingrese el modelo por el que va a consultar: ");
                                string modeloConsultado = Console.ReadLine();
                                Console.WriteLine("");

                                if (tipoTelefono == "Telefono Inteligente")
                                {


                                    for (int i = 0; i < registro_Inteligente.Length; i++)
                                    {

                                        if (registro_Inteligente[i].Modelo == modeloConsultado)                                                            
                                        {                                          
                                            Console.WriteLine("**** INFORMACION ****");
                                            Console.WriteLine("Disponible del " + modeloConsultado + " es : " + registro_Inteligente[i].Stock);
                                            Console.WriteLine("");
                                            registro_Inteligente[i].MostrarInformacionInteligente();                                        

                                        }
                                    }
                                }
                                else if (tipoTelefono == "Telefono Basico")
                                {
                                    for (int i = 0; i < registro_Basico.Length; i++)
                                    {
                                        if (registro_Basico[i].Modelo == modeloConsultado)
                                        {                                          
                                            Console.WriteLine("**** INFORMACION ****");
                                            Console.WriteLine("Disponible del " + modeloConsultado + " es : " + registro_Basico[i].Stock);
                                            Console.WriteLine();
                                            registro_Basico[i].MostrarInformacionBasico();                                          

                                        }
                                    }

                                }

                                break;

                            case 4:

                                Console.WriteLine(" ░░░░░░░░░░░░░░░░░░░Saliendo del inventario░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                                Console.WriteLine();

                                break;


                            default:

                                Console.WriteLine("Incorrecto");

                                break;

                        }

                        if (opcion > 0 && opcion <= 4)
                        {

                            break;

                        }
                        else
                        {
                            intentos++;  
                            if (intentos < 3)
                            {
                                Console.WriteLine("Este dato no existe.");
                                Console.WriteLine();

                            }
                            else if (intentos == 3)
                            {
                                Console.WriteLine("Error, se intento varias veces!");
                                Console.WriteLine();

                           }
                        }
                    }
                    catch (Exception e)
                    { 
                        intentos++;

                        if (intentos < 3)
                        {
                            Console.WriteLine("Este dato no es valido.");
                            Console.WriteLine();

                        }
                        else if (intentos == 3)
                        {
                            Console.WriteLine("¡Error! , Ha intentado varias veces!");
                            Console.WriteLine();
                      }
                    }
                }
            } while (opcion != 4);
           
            Console.WriteLine("El Programa ha finalizado");
          

        }
    }
}