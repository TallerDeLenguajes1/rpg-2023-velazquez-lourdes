namespace espacioPersonaje
{
    public class personaje
    {
        private int velocidad; //1 a 10
        private int destreza; //1 a 5
        private int fuerza; //1 a 10
        private int nivel; //1 a 10
        private int armadura; //1 a 10
        private int salud; // 100
        private string? tipo;
        private  string? nombre;
        private  string? apodo;
        private int edad;
        private DateTime fechaNacimiento;

        public personaje()
        {
        }

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Salud { get => salud; set => salud = value; }
     
        public int Edad { get => edad; set => edad = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        internal string? Nombre { get => nombre; set => nombre = value; }
        internal string? Apodo { get => apodo; set => apodo = value; }
        internal string? Tipo { get => tipo; set => tipo = value; }
    }
}