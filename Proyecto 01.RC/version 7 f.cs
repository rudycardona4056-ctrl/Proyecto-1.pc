int opcion;        /*Guardamos variable de opcion*/           /**/
int tipodeentre;   /*Guardamos variable del tipo de entretenimiento*/
int duracion;      /*Guardamos variable de duracion*/
int clasifi;       /*Guardamos variable de clasificacion*/
int horaprogra;       /*Guardamos variable de la hora programada*/
int nivelprodu;         /*Guardamos variable del nivel de produccion*/
int ttevaluados = 0;     /*Guardamos variable que va contar de total evaluados*/
int rechazados = 0;      /*Guardamos variable que va contar los rechazados*/
string impacto;        /*Guardamos variable de impacto*/
int revision = 0;           /*Guardamos variable que va contar las revisiones*/
int publicarla = 0;         /*Guardamos variable que va contar al publicarla*/
double porcentaje;            /*Guardamos variable de porcentaje*/


do        /*se repite el ciclo hasta que el usuario decida salir*/
{
    Console.WriteLine(" MENU ");
    Console.WriteLine("1. Evaluar contenido nuevo");
    Console.WriteLine("2. Mostrar reglas del sistema");
    Console.WriteLine("3. Mostrar estadisticas");               /*Menu*/
    Console.WriteLine("4. Reinciar estadisticas");
    Console.WriteLine("5. Salir");
    Console.Write("Elija una opcion: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion < 1 || opcion > 5)         /*verifica si esta en los numeros permitidos*/
    {
        Console.WriteLine("La Opcion es invalida");     /*salida*/
    }
    switch (opcion)
    {
        case 1:
            Console.WriteLine("1. Pelicula");
            Console.WriteLine("2. Serie");               /*menu de entretenimientos*/
            Console.WriteLine("3. Documental");
            Console.WriteLine("4. Evento vivo");

            do             /*que ingrese del 1 al 4*/
            {
                Console.WriteLine("Seleccione tipo");
                tipodeentre = int.Parse(Console.ReadLine());
            } while (tipodeentre < 1 || tipodeentre > 4);

            do       /*duracion valida*/
            {
                Console.Write("Minutos: ");
                duracion = int.Parse(Console.ReadLine());
            } while (duracion < 1);

            Console.WriteLine("Clasificacion");
            Console.WriteLine("1. Todo publico");
            Console.WriteLine("2. +13");               /*menu de claisificacion*/
            Console.WriteLine("3. +18");
            clasifi = int.Parse(Console.ReadLine());

            do         /*solicitamos hora*/
            {
                Console.Write("Hora programada 0-23: ");
                horaprogra = int.Parse(Console.ReadLine());
            } while (horaprogra < 0 || horaprogra > 23);        /*de 0 a 23*/

            Console.WriteLine("Nivel produccion");
            Console.WriteLine("1. Bajo");              /*menu de produccion*/
            Console.WriteLine("2. Medio");
            Console.WriteLine("3. Alto");

            do         /*solicitamos nivel*/
            {
                nivelprodu = int.Parse(Console.ReadLine());
            } while (nivelprodu < 1 || nivelprodu > 3);

            ttevaluados++;     /*va aumentando el contador*/

            bool esvalido = true;   /*guardamos variable para los contenidos validados*/
            string razon = "";      /*guardamos variable cuando sea rechazada*/

            if (clasifi == 2)        /*condicionamos */
            {
                if (horaprogra < 6 || horaprogra > 22)  /*si es de 6 a 22 es valido*/
                {
                    esvalido = false;
                    razon = "Horario no valido +13"; /*si no cumple entonces mostramos mensaje*/
                }
            }
            else if (clasifi == 3)     /*condicionamos*/
            {
                if (horaprogra > 5 && horaprogra < 22)    /*si si es de 5 a 22 hrs */
                {
                    esvalido = false;
                    razon = "Horario no valido +18";   /*si no cumple entonces mostramos mensaje*/
                }
            }

            if (esvalido)    /*validamos la duracion*/
            {
                if (tipodeentre == 1)  /*si selecciona pelicula 1*/
                {
                    if (duracion < 60 || duracion > 180)     /*si la duracion es entre 60 a 180*/
                    {
                        esvalido = false;
                        razon = "La duracion es invalida"; /*si no cumple entonces mostramos mensaje*/
                    }
                }
                else if (tipodeentre == 2)     /*si selecciona serie 2*/
                {
                    if (duracion < 20 || duracion > 90)   /*si dura de 20 a 90*/
                    {
                        esvalido = false;
                        razon = "Serie con duracion invalida";     /*si no cumple entonces motramos mensaje*/
                    }
                }
                else if (tipodeentre == 3)    /*si selecciona documental 3*/
                {
                    if (duracion < 30 || duracion > 120)  /*si dura entre 30 y 120*/
                    {
                        esvalido = false;
                        razon = "Documental con duracion invalida";    /*si no cumple entonces mostramos mensaje*/
                    }
                }
                else if (tipodeentre == 4)     /*si selecciona evento 4*/
                {
                    if (duracion < 30 || duracion > 240) /*si dura entre 30 y 240*/
                    {
                        esvalido = false;
                        razon = "Evento con duracion invalida"; /*si no cumple entonces mostramos mensaje*/
                    }
                }
            }

            if (esvalido)    /*validamos nivel de produccion*/
            {
                if (nivelprodu == 1)        /*si selecciona*/
                {
                    if (clasifi == 3)       /*si cumple*/
                    {
                        esvalido = false;
                        razon = "Nivel bajo no +18"; /*si no cumple mostramos mensaje*/
                    }
                }
            }

            if (!esvalido)        /*cuando no validamos*/
            {
                Console.WriteLine("RECHAZADO");
                Console.WriteLine("Razon: " + razon);
                rechazados++;               /*acumula rachazados*/
            }
            else
            {
                /*verificamos los impactos*/
                impacto = "Bajo";

                if (nivelprodu == 3)     /*condicionamos*/
                {
                    impacto = "Alto";
                }
                else if (duracion > 120)    /*condicionamos*/
                {
                    impacto = "Alto";
                }
                else if (horaprogra >= 20)     /*condicionamos*/
                {
                    if (horaprogra <= 23)     /**/
                    {
                        impacto = "Alto";
                    }
                }
                else if (nivelprodu == 2 || (duracion >= 60 && duracion <= 120))/**/
                {
                    impacto = "Medio";
                }

                if (impacto == "Alto")       /*decidimos el contenio*/
                {
                    Console.WriteLine("Decision: revision"); /*salida*/
                    revision++;    /*aumenta revision*/
                }
                else
                {
                    Console.WriteLine("Decision: publicar");   /*salida*/
                    publicarla++;  /*aumenta publicarla*/
                }
                Console.WriteLine("Impacto: " + impacto); /*mostramos el impacto respectivo*/
            }
            break;

        case 2:
            Console.WriteLine("Reglas");
            Console.WriteLine("+13: de 6-22");
            Console.WriteLine("+18: de 22-5");       /*Menu de Reglas*/
            Console.WriteLine("Bajo no +18");
            break;

        case 3:
            Console.WriteLine("Evaluados: " + ttevaluados);
            Console.WriteLine("Publicar: " + publicarla);
            Console.WriteLine("Rechazados: " + rechazados);   /*Mostramos estadisticas*/
            Console.WriteLine("Revision: " + revision);

            if (ttevaluados > 0)       /*calculamos*/
            {
                porcentaje = (publicarla * 100.0) / ttevaluados;
                Console.WriteLine("Aprobacion: " + porcentaje + "%");  /*mostramos porcentaje*/
            }

            for (int i = 1; i <= ttevaluados; i++)
            {
                Console.WriteLine("Contenido evaluado: " + i); /*mostramos contenido evaluado*/
            }
            break;

        case 4:          /*Reinicamos estadisticas*/
            ttevaluados = 0;
            rechazados = 0;
            revision = 0;
            publicarla = 0;
            Console.WriteLine("Estadisticas ya reiniciadas");
            break;

        case 5:  /*si quiere salir del sistema*/
            Console.WriteLine("Saliendo..................");
            break;

        default:  /*si la opcion es invalida*/
            Console.WriteLine("Opcion invalida");
            break;
    }
} while (opcion != 5);   /*la opcion se repite hasta que elija el numero 5*/