using Actividad3Unidad2.Modelos;
using System;

namespace Actividad3Unidad2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool seguir = true;
            do
            {
                var empleado = new Empleados();
                var boleto = new Boletos();
                Console.Clear(); // me servira para limpiar pantalla
                Console.WriteLine("DHP");   // mensaje de titulo             
                Console.WriteLine("--------Menu-----------"); // mensaje
                Console.WriteLine("1- Programa Empleados"); // mensaje
                Console.WriteLine("2- Programa Boletos"); // mensaje
                Console.WriteLine("3- Salir"); // mensaje
                Console.WriteLine("----Elija una opcion----"); // mensaje
                // ** int.TryPArse es la mejor manera de validar y convertir un dato a otro tipo de dato en una sola linea
                // lo que hago aqui es leer/recibir lo que el usuario escribe con teclado y a su vez lo asigno (out)
                // a una variable (llamada "opt" en este caso) del tipo que deseo convertir
                var opcion = int.TryParse(Console.ReadLine(), out int opt);
                switch (opt) // la variable que va a ser revisada segun su valor
                {
                    case 1: // si la variable vale 1
                        Console.Clear(); // me servira para limpiar pantalla
                        empleado.IngresarEmpleado();// ejecuta metodo para el programa empleados
                        break;
                    case 2: // si la variable vale 2
                        Console.Clear(); // me servira para limpiar pantalla
                        boleto.ComprarBoletos();// ejecuta el metodo para programa boletos
                        break;
                    case 3: // si la variable vale 3
                        Console.Clear(); // me servira para limpiar pantalla
                        Console.WriteLine("GRACIAS POR USAR EL PROGRAMA"); // mensaje
                        Console.ReadKey(); // en espera de que se presione una tecla
                        seguir = false;// cambio el valor de la variable para salir del programa
                        break;
                    default:
                        Console.Clear(); // me servira para limpiar pantalla
                        Console.WriteLine("SELECCION INVALIDA, VUELVA A INTENTARLO"); // mensaje
                        Console.ReadKey(); // // en espera de que se presione una tecla
                        Console.Clear(); // me servira para limpiar pantalla
                        break;
                }
            } while (seguir); // condicion al final, cuando deje de ser verdadera, acabara el programa
        }
    }
}
