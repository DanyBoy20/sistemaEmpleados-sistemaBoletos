using System;
using System.Collections.Generic;
using System.Linq;

namespace Actividad3Unidad2.Modelos
{
    class Empleados
    {
        // propiedades de la clase empleados
        public List<Empleado> CapturaEmpleados { get; set; } // lista de tipo empleados

        public Empleados() // constructor
        {
            CapturaEmpleados = new List<Empleado>(); // variable para la lista
        }

        // metodo para ingresar el empleado y hacer calculos
        public void IngresarEmpleado()
        {
            var empleado = new Empleado(); // instancia de la clase
            int cantidad; // para determinar la cantidad de empleados a insertar
            bool validar = true; // para validar la salida del bucle do while
            Console.Clear(); // me servira para limpiar pantalla
            Console.Write("¿CUANTOS EMPLEADOS DESEA REGISTRAR HOY?: ");   // mensaje de titulo
            cantidad = int.Parse(Console.ReadLine()); // capturo lo que el usuario escribe con teclado y lo asigno a variable 
            for (int i = 0; i < cantidad; i++) // bucle for para ingresar los empleados segun la cantidad que se determino
            {
                Console.Clear(); // me servira para limpiar pantalla
                Console.Write("Escriba nombre del empleado: "); // mensaje pidiendo datos
                empleado.Nombre = Console.ReadLine(); // capturo lo que el usuario escribe con teclado y lo asigno a variable Nombre
                Console.Write("Escriba su sueldo: $ "); // mensaje pidiendo datos
                empleado.Salario = Double.Parse(Console.ReadLine()); // capturo lo que el usuario escribe con teclado y lo asigno a variable                 
                CapturaEmpleados.Add(empleado); // añado toda la informacion a la lista
            }
            double total = CapturaEmpleados.Sum(sueldo => sueldo.Salario); // sumo los salarios de los empleados
            Console.Clear(); // me servira para limpiar pantalla
            Console.WriteLine("El total invertido en sueldos es de: $ {0}", total); // muestro los salarios
            do // bucle do while para mostrar dos opciones: si desea conservar la lista o borrarla
            {
                Console.WriteLine("¿Desea conservar la lista de empleados?"); // mensaje
                Console.WriteLine("1- Si | 2- No"); // mensaje en pantalla
                bool esNumero = int.TryParse(Console.ReadLine(), out int variable1); // capturo el valor y lo paso a variable boleana para evaluarla
                if (!esNumero) // si el valor ingresado no es un numero entero
                {
                    Console.Clear(); // me servira para limpiar pantalla
                    Console.WriteLine("Opcion no valida, intente nuevamente"); // mensaje de aviso
                    Console.ReadKey(); // en espera de que el usuario presione una tecla
                    Console.Clear(); // limpio pantalla
                }
                else 
                {
                    switch (variable1) // en un switch valido la insercion por teclado del usuario
                    {
                        case 1: // si fue 1
                            validar = false; // asigno falso a variable para salir del bucle 
                            Console.Clear(); // limpio pantalla
                            break;
                        case 2: // si fue 2
                            CapturaEmpleados.Clear(); // borro la lista
                            validar = false; // asigno falso a variable para salir del bucle 
                            Console.Clear(); // limpio pantalla
                            break;
                        default: // si no fue ninguna de las anteriores
                            Console.WriteLine("Opcion invalida, se eliminaran los datos guardados, presione una tecla para continuar");
                            CapturaEmpleados.Clear(); // borro la lista
                            validar = false; // asigno falso a variable para salir del bucle
                            Console.ReadKey(); // espero captura por teclado del usuario
                            break;
                    }
                }
            } while (validar); // mientras que validar sea verdadera
        }
    }
}
