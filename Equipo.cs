namespace PasrtidoBascket;

// Clase que contiene todo para crear un equipo de 3 para el juego
public class Equipo
{
    //array para almacenar jugadores
    private Jugador[] jugadores;
    private int cantidadJugadores;

    public Equipo()
    {
        jugadores = new Jugador[3];
        cantidadJugadores = 0;
    }
     public void MostrarResumen()
    {
        Console.WriteLine("Resumen del equipo:");
        for (int i = 0; i < 3; i++)
        {
            if (jugadores[i] != null)
            {
                Console.WriteLine($"Jugador {i + 1}: {jugadores[i].Nombre} ({jugadores[i].Posicion}) - Rendimiento: {jugadores[i].Rendimiento}");
            }
        }
    }

    public void AgregarJugador(Jugador jugador)
    {
        if (cantidadJugadores < 3)
        {
            jugadores[cantidadJugadores] = jugador;
            cantidadJugadores++;
        }
        else
        {
            Console.WriteLine("El equipo ya tiene 3 jugadores. No se puede agregar más.");
        }
    }

    public int CalcularPuntaje()
    {
        int puntajeTotal = 0;

        foreach (var jugador in jugadores)
        {
            if (jugador != null)
            {
                puntajeTotal += jugador.Rendimiento;
            }
        }
        

        return puntajeTotal;
    }
}
