using System;

class Menu
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Ventas Varias ===");
            Console.WriteLine("1. TRANSITORE");
            Console.WriteLine("2. CAPACITADORES");
            Console.WriteLine("3. LEDs");
            Console.WriteLine("4. SALIR");
            Console.WriteLine("=====================");
            Console.WriteLine("SELECIONE UNA OPCION ");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Has seleccionado la opción 1: Transistores.");
                    Console.WriteLine("a. TRANSITOR NPN");
                    Console.WriteLine("b. TRANSITOR PNP");
                    Console.WriteLine("c. TRANSITOR MOSFET");
                    Console.WriteLine("d. VOLVER AL MENU PRINCIPAL");
                    Console.WriteLine("Seleccione una opción: ");

                    string opcionTransistor = Console.ReadLine();
                    switch (opcionTransistor)
                    {
                        case "a":
                            Console.WriteLine("HAS SELECI0NADO TRANSITOR NPN.");
                            break;
                        case "b":
                            Console.WriteLine("HAS SELECI0NADO TRANSITOR PNP.");
                            break;
                        case "c":
                            Console.WriteLine("HAS SELECI0NADO TRANSITOR MOSFET.");
                            break;
                        case "d":
                            break;
                      
                    }
                    break;

                case "2":
                    Console.WriteLine("Has seleccionado la opción 2: Capacitores.");
                    Console.WriteLine("a. CAPACITOR ELECTROLITICO");
                    Console.WriteLine("b. CAPACITOR CERAMICO");
                    Console.WriteLine("c. CAPACITOR TANTALIO");
                    Console.WriteLine("d. VOLER A MENU PRINCIPAL");
                    Console.WriteLine("Seleccione una opción: ");

                    string opcionCapacitor = Console.ReadLine();
                    switch (opcionCapacitor)
                    {
                        case "a":
                            Console.WriteLine("HAS SELECCIONADO CAPACITOR ELECTROLITICO .");
                            break;
                        case "b":
                            Console.WriteLine("HAS SELECCIONADO CAPACITOR CERAMICO.");
                            break;
                        case "c":
                            Console.WriteLine("HAS SELECCIONADO CAPACITOR TENTALIO.");
                            break;
                        case "d":
                            break;
                       
                    }
                    break;

                case "3":
                    Console.WriteLine("Has seleccionado la opción 3: LEDs.");
                    Console.WriteLine("a.LED ROSADO");
                    Console.WriteLine("b.LED MORADO");
                    Console.WriteLine("c.LED AZUl");
                    Console.WriteLine("d.VOLVER A MENU PRINCIPAL");
                    Console.WriteLine("Seleccione una opción: ");

                    string opcionLED = Console.ReadLine();
                    switch (opcionLED)
                    {
                        case "a":
                            Console.WriteLine("HAS SELECIONDO EL LED ROSADO.");
                            break;
                        case "b":
                            Console.WriteLine("HAS SELECIONDO EL LED MORADO.");
                            break;
                        case "c":
                            Console.WriteLine("HAS SELECIONDO EL LED Azul.");
                            break;
                        case "d":
                            break;
                        
                    }

                    break;
                case "4":
                    Console.WriteLine("Saliendo del Programa......");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opcion no valida. Intente de nuevo");
                    break;

            }

            if (continuar)
            {
                Console.WriteLine("Presione cualquier para continuar... ");
                Console.ReadKey();
            }

        }
    }
}
