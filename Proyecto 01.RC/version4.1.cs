int opcion;        /*Guardamos variable de opcion*/           /**/
int tipodeentre;   /*Guardamos variable del tipo de entretenimiento*/
int duracion;      /*Guardamos variable de duracion*/
int clasifi;       /*Guardamos variable de clasificacion*/
int horaprogra;       /*Guardamos variable de la hora programada*/
int nivelprodu;         /*Guardamos variable del nivel de produccion*/
int ttevaluados = 0;     /*Guardamos variable que va contar de total evaluados*/

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