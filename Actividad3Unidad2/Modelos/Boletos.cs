using System;

namespace Actividad3Unidad2.Modelos
{
    class Boletos
    {
        bool continuar = true; // variable para continuar en el bucle o salir - al inicio es verdadera
        int opcion, cantidad, resultado; // variables: opcion es para validar el switch, cantidad = # de boletos, resultado= costo total

        // metodo para seleccionar gradas y comprar boletos
        public void ComprarBoletos()
        {
            while (continuar) // mientras se desee continuar
            {
                Console.WriteLine("SELECCIONE UN SECTOR DEL ESTADIO"); // mensaje pidiendo datos
                Console.WriteLine("(1) GRADAS ALTAS = $50"); // mensaje
                Console.WriteLine("(2) GRADAS MEDIAS = $80"); // mensaje
                Console.WriteLine("(3) GRADAS CANCHA = $120"); // mensaje
                Console.WriteLine("(4) GRADAS PREFERENTE = $200"); // mensaje
                bool esNumero = int.TryParse(Console.ReadLine(), out opcion); // capturo el valor y lo paso a variable boleana para evaluarla
                if (!esNumero) // si el valor ingresado no es un numero entero
                {
                    Console.Clear(); // limpiar pantalla
                    Console.WriteLine("DEBE INGRESAR SOLO NUMEROS ENTEROS ACORDE AL MENU"); // mensaje de aviso
                    Console.ReadKey(); // esperar por tecla presionada
                }
                else // sino
                {
                    switch (opcion) // en un switch evaluo la variable para determinar en que rango esta
                    {
                        case 1: 
                            Console.Clear(); // limpiar pantalla
                            Console.WriteLine("Ingrese la cantidad de boletos a comprar: "); // mensaje pidiendo datos
                            int.TryParse(Console.ReadLine(), out cantidad); // capturo el valor y lo paso a variable boleana para evaluarla
                            resultado = cantidad * 50; // operacion y resultado
                            Console.Clear(); // limpiar pantalla
                            Console.WriteLine($"El pago total de {cantidad} boletos en gradas altas es de: $ {resultado} ", resultado);
                            continuar = false; // asigno falso para salir del bucle while
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ReadKey(); // esperar por tecla presionada
                            break; // salir del caso
                        case 2: 
                            Console.Clear(); // limpiar pantalla
                            Console.WriteLine("Ingrese la cantidad de boletos a comprar: "); // mensaje pidiendo datos
                            int.TryParse(Console.ReadLine(), out cantidad); // capturo el valor y lo paso a variable boleana para evaluarla
                            resultado = cantidad * 80; // operacion y resultado
                            Console.Clear(); // limpiar pantalla
                            Console.WriteLine($"El pago total de {cantidad} boletos en gradas medias es de: $ {resultado} ", resultado);
                            continuar = false; // asigno falso para salir del bucle while
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ReadKey(); // esperar por tecla presionada
                            break;// salir del caso
                        case 3: 
                            Console.Clear(); // limpiar pantalla
                            Console.WriteLine("Ingrese la cantidad de boletos a comprar: "); // mensaje pidiendo datos
                            int.TryParse(Console.ReadLine(), out cantidad); // capturo el valor y lo paso a variable boleana para evaluarla
                            resultado = cantidad * 120; // operacion y resultado
                            Console.Clear(); // limpiar pantalla
                            Console.WriteLine($"El pago total de {cantidad} boletos en gradas cancha es de: $ {resultado} ", resultado);
                            continuar = false; // asigno falso para salir del bucle while
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ReadKey(); // esperar por tecla presionada
                            break;// salir del caso
                        case 4: 
                            Console.Clear(); // limpiar pantalla
                            Console.WriteLine("Ingrese la cantidad de boletos a comprar: "); // mensaje pidiendo datos
                            int.TryParse(Console.ReadLine(), out cantidad); // capturo el valor y lo paso a variable boleana para evaluarla
                            resultado = cantidad * 200; // operacion y resultado
                            Console.Clear(); // limpiar pantalla
                            Console.WriteLine($"El pago total de {cantidad} boletos en gradas preferente es de: $ {resultado} ", resultado);
                            continuar = false; // asigno falso para salir del bucle while
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ReadKey(); // esperar por tecla presionada
                            break;// salir del caso
                        default:
                            Console.Clear(); // limpiar pantalla
                            Console.WriteLine("Opción invalida, presione cualquier tecla para intentarlo nuevamente"); // 
                            Console.ReadKey(); // esperar por tecla presionada
                            break; // salir del caso
                    }
                }
            }
        }
    }
}
