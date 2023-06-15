using espacioPersonaje;
using espacioFabricaPersonaje;
internal class Program
{
    private static void Main(string[] args)
    {
        personaje personaje1 = new personaje();
        FabricaPersonaje.contructorPersonje(personaje1);
        FabricaPersonaje.mostrar(personaje1);
    }
}