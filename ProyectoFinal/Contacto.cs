public class Contacto
{
    private int id;
    private string nombre;
    private string email;
    private string telefono;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    // Constructor sin ID
    public Contacto(string nombre, string email, string telefono)
    {
        this.nombre = nombre;
        this.email = email;
        this.telefono = telefono;
    }

    // Constructor con ID
    public Contacto(int id, string nombre, string email, string telefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.email = email;
        this.telefono = telefono;
    }
}
