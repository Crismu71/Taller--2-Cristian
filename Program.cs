using PasrtidoBascket;

class Program
{
    static void Main(string[] args)
    {
        List<Jugador> jugadoresRegistrados = new List<Jugador>
        {
            new Jugador("Jugador1", "Delantero", 8),
            new Jugador("Jugador2", "Base", 7),
            new Jugador("Jugador3", "Centro", 9),
            new Jugador("Jugador4", "Delantero", 6),
            new Jugador("Jugador5", "Base", 7),
            new Jugador("Jugador6", "Centro", 8)
        };

        Equipo equipo1 = new Equipo();
        Equipo equipo2 = new Equipo();

        Random rand = new Random();
        while (jugadoresRegistrados.Count > 0)
        {
            int index = rand.Next(jugadoresRegistrados.Count);
            Jugador jugadorSeleccionado = jugadoresRegistrados[index];

            if (equipo1.CalcularPuntaje() <= equipo2.CalcularPuntaje())
            {
                equipo1.AgregarJugador(jugadorSeleccionado);
            }
            else
            {
                equipo2.AgregarJugador(jugadorSeleccionado);
            }

            jugadoresRegistrados.RemoveAt(index);
        }

        Console.WriteLine("Resumen del Equipo 1:");
        equipo1.MostrarResumen();
        Console.WriteLine("Puntaje total del Equipo 1: " + equipo1.CalcularPuntaje());

        Console.WriteLine("\nResumen del Equipo 2:");
        equipo2.MostrarResumen();
        Console.WriteLine("Puntaje total del Equipo 2: " + equipo2.CalcularPuntaje());

        if (equipo1.CalcularPuntaje() > equipo2.CalcularPuntaje())
        {
            Console.WriteLine("\nEl equipo 1 es el ganador con un puntaje de " + equipo1.CalcularPuntaje());
        }
        else if (equipo2.CalcularPuntaje() > equipo1.CalcularPuntaje())
        {
            Console.WriteLine("\nEl equipo 2 es el ganador con un puntaje de " + equipo2.CalcularPuntaje());
        }
        else
        {
            Console.WriteLine("\nEl partido terminó en empate.");
        }
    }
}