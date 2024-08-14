public class Cliente
{
    public string Nombre { get; set; }
    public string CorreoElectronico { get; set; }
    public string NumeroTelefono { get; set; }

    public Cliente(string nombre, string correo, string telefono)
    {
        Nombre = nombre;
        CorreoElectronico = correo;
        NumeroTelefono = telefono;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Nombre: {Nombre}, Correo: {CorreoElectronico}, Teléfono: {NumeroTelefono}");
    }
}