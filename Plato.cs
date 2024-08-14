public class Plato
{
    public string Nombre { get; set; }
    public float Precio { get; set; }

    public Plato(string nombre, float precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Plato: {Nombre}, Precio: {Precio:C}");
    }
}
