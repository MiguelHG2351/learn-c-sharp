namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string Nombre{
            get {
                return nombre;
            }
            set {
                nombre = value.ToUpper();
            }
        }
        // Shortcut the
        public int año {get; set;}

        public string pais { get; set; }

        public TiposDeEscuelas TipoDeEscuela { get; set; }

    // public Escuela(string nombre, int año) {
    //     this.nombre = nombre;
    //     this.año = año;
    // }
    public Escuela(string nombre, int año) => (Nombre, this.año) = (nombre, año);
    public Escuela(string nombre, int año, TiposDeEscuelas tipos, string pais = "Managua") {
        (Nombre, this.año) = (nombre, año);
    }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Pais: {pais} tipo: {TipoDeEscuela}";
        }

    }
}