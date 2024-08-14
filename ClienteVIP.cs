public class ClienteVIP : Cliente
{
    public float Descuento { get; set; }

    public ClienteVIP(string nombre, string correo, string telefono, float descuento)
        : base(nombre, correo, telefono)
    {
        Descuento = descuento;
    }

    public void AplicarDescuento(ref float total)
    {
        total -= total * Descuento;
    }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine($"Descuento: {Descuento * 100}%");
    }
}
