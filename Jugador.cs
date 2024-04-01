namespace PasrtidoBascket;

//clase que usa la interfaz y sera el modelo para los juegadores
public class Jugador : InterfazJugador
{
    public string Nombre { get; private set; }
    public string Posicion { get; private set; }
    public int Rendimiento { get; private set; }

    //Constructor que inicializa atributos
    public Jugador(string nombre, string posicion, int rendimiento)
    {
        Nombre = nombre;
        Posicion = posicion;
        Rendimiento = rendimiento;
    }
}