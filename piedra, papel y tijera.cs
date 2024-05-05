// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

Console.WriteLine("hello, vamos a jugar piedra papel o tijera ");

// nombre del jugador
Console.WriteLine("ingrese su nombre para empezar a jugar ");
string n1 = Console.ReadLine();

int selecciondelIA = 0;
int selecciondeljugador = 0;

// se inicia con puntuacion 0
int puntajedeljugador = 0;
int puntajedelIA = 0;
int veces = 0;


Random IA = new Random();
while (veces<5)
{

    selecciondelIA = IA.Next(1, 4);


    Console.WriteLine($"El marcador actual es de {puntajedelIA} puntos para la IA y {puntajedeljugador} puntos para {n1}");
    Console.WriteLine("ingrese {1} para piedra, ingrese {2} para papel e ingrese {3} para tijera");
    selecciondeljugador = Convert.ToInt32(Console.ReadLine());


    if (selecciondeljugador == 1)
    {
        Console.WriteLine("usted escogio Piedra");
        if (selecciondelIA == 1)
        {
            Console.WriteLine("la IA escogio piedra");
            Console.WriteLine("ambos sacaron Piedra, vuelve a jugar.");
        }
        else
        {
            if (selecciondelIA == 2)
            {
                Console.WriteLine("la IA escogio papel");
                Console.WriteLine($"papel atrapa a piedra, la IA gana un punto");
                veces++;
                puntajedelIA++;
            }
            else
            {
                if (selecciondelIA == 3)
                {
                    Console.WriteLine("la IA escogio tijeras");
                    Console.WriteLine($"piedra aplasta tijeras, el jugador gana un punto");
                    veces++;
                    puntajedeljugador++;
                }
            }
        }
    }


    if (selecciondeljugador == 2)
    {
        Console.WriteLine("usted eligio Papel");
        if (selecciondelIA == 1)
        {
            Console.WriteLine("la IA escogio piedra");
            Console.WriteLine("papel atrapa a piedra, el jugador gana un punto.");
            veces++;
            puntajedeljugador++;
        }
        else
        {
            if (selecciondelIA == 2)
            {
                Console.WriteLine("la IA escogio papel");
                Console.WriteLine("ambos sacaron papel, vuelve a jugar");
            }
            else
            {
                if (selecciondelIA == 3)
                {
                    Console.WriteLine("la IA escogio tijeras");
                    Console.WriteLine("tijeras corta papel, la IA gana un punto");
                    veces++;
                    puntajedelIA++;
                }

            }
        }
    }

    if (selecciondeljugador == 3)
    {
        Console.WriteLine("usted eligio tijeras");
        if (selecciondelIA == 1)
        {
            Console.WriteLine("la IA escogio piedra");
            Console.WriteLine("piedra aplasta tijeras,la IA gana un punto");
            veces++;
            puntajedelIA++;
        }
        else
        {
            if (selecciondelIA == 2)
            {
                Console.WriteLine("la IA escogio papel");
                Console.WriteLine("tijeras corta papel,el jugador gana un punto");
                veces++;
                puntajedeljugador++;
            }
            else
            {
                if (selecciondelIA == 3)
                {
                    Console.WriteLine("la IA escogio tijeras");
                    Console.WriteLine("ambos sacaron tijeras, vuelve a jugar");
                }
            }
        }
    }
    if(selecciondeljugador>=4)
    {
        Console.WriteLine("El valor que ingreso no es valido, ingrese nuevamente su numero");
    }
}

Console.WriteLine($"la IA tuvo un total de {puntajedelIA} puntos y el jugador tuvo un total de {puntajedeljugador} puntos.");

if (puntajedelIA < puntajedeljugador)
{
    Console.WriteLine($"{n1} usted le ha ganado a la IA, felicitaciones.");
}
else
{
    Console.WriteLine($"{n1} usted perdio contra la IA,juegue de nuevo.");
}

Console.WriteLine("FIN DEL JUEGO, ESPERO LE HAYA GUSTADO");



