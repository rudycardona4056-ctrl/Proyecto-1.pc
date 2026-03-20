int opcion;
int tipoentretenimiento;
int duracion;
int clasifi;
int ttevaluados = 0;
int horaprogra;
int nivelprodu;


do
{
    Console.WriteLine("1. Evaluar contenido nuevo");
    Console.WriteLine("2. Mostrar reglas del sistema");
    Console.WriteLine("3. Mostrar estadisticas");
    Console.WriteLine("4. Reinciar estadisticas");
    Console.WriteLine("5. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            {
                Console.WriteLine("1. Pelicual");
                Console.WriteLine("2. Serie");
                Console.WriteLine("3.Documental");
                Console.WriteLine("4.Evento en vivo");
                tipoentretenimiento = int.Parse(Console.ReadLine());

                if (tipoentretenimiento < 1 || tipoentretenimiento > 4)
                {
                    Console.WriteLine("Opcion invalida");
                }

                Console.WriteLine("Duracion en minutos");
                duracion = int.Parse(Console.ReadLine()); ;

                Console.WriteLine("Clasificacion");
                Console.WriteLine("1. Todo publico");
                Console.WriteLine("2. +13");
                Console.WriteLine("3. +18");
                clasifi = Console.ReadLine();

                Console.Write("La hora programada (0-23)");
                horaprogra = int.Parse(Console.ReadLine());

                Console.WriteLine("Nivel de la produccion");
                Console.WriteLine("1. Bajo");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Alto");
                nivelprodu = int.Parse(Console.ReadLine());

                ttevaluados++;

                bool valida = true;

                string razon = "";

                if (clasifi == "+13" && (horaprogra < 6 || horaprogra > 22))
                {
                    valida = false;

                    razon = "Horario no valido para +13";
                }
                else if (clasifi == "+18" && !(horaprogra >= 22 || horaprogra <= 5))
                {
                    valida = false;
                    razon = "Horaio no valido para +18";
                }
            }
    }
}