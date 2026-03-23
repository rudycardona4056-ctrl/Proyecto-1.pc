using System;

class Program
{

    static void Main()
    {
        do        /*se repite el ciclo hasta que el usuario decida salir*/
        {
            opcion = Menu();   /**/

            if (opcion < 1 || opcion > 5)         /*verifica si esta en los numeros permitidos*/
            {
                Console.WriteLine("La Opcion es invalida");     /*salida*/
            }

            switch (opcion)
            {
                case 1:
                    Evaluar();   /**/
                    break;

                case 2:
                    Reglas();    /**/
                    break;

                case 3:
                    Estadisticas();   /**/
                    break;

                case 4:
                    Reiniciar();   /**/
                    break;

                case 5:  /*si quiere salir del sistema*/
                    Console.WriteLine("Saliendo..................");
                    break;

                default:  /*si la opcion es invalida*/
                    Console.WriteLine("Opcion invalida");
                    break;
            }

        } while (opcion != 5);   /*la opcion se repite hasta que elija el numero 5*/
    }
