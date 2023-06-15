using espacioPersonaje;
namespace espacioFabricaPersonaje
{
    public class FabricaPersonaje
    {
        
        static public void contructorPersonje(personaje p1)
        {
                p1.Velocidad = new Random().Next(1 , 10);
                p1.Armadura = new Random().Next(0, 10);
                p1.Destreza = new Random().Next(0, 10);
                p1.Fuerza = new Random().Next(0, 10);
                p1.Nivel=2;
                p1.Salud =new Random().Next(0, 100);
        }
        static public void mostrar(personaje p1)
        {
            Console.WriteLine("Velocidad:" + p1.Velocidad);
            Console.WriteLine("Armadura: " + p1.Armadura);
            Console.WriteLine("Destreza: " + p1.Destreza);
            Console.WriteLine("Fuerza: " + p1.Fuerza);
        }
    }
}