public class Reserva
{
    public int NumeroReserva { get; set; }
    public DateTime Fecha { get; set; }
    public TimeSpan Hora { get; set; }
    public Cliente Cliente { get; set; }
    public List<Plato> ListaPlatos { get; set; }
    public float Total { get; set; }

    public Reserva(int numeroReserva, DateTime fecha, TimeSpan hora, Cliente cliente)
    {
        NumeroReserva = numeroReserva;
        Fecha = fecha;
        Hora = hora;
        Cliente = cliente;
        ListaPlatos = new List<Plato>();
    }

    public void CalcularTotal()
    {
        Total = ListaPlatos.Sum(plato => plato.Precio);
        if (Cliente is ClienteVIP vipCliente)
        {
            Total = vipCliente.AplicarDescuento(Total);
        }
    }


    public void MostrarDetalles()
    {
        Console.WriteLine($"Reserva No.: {NumeroReserva}, Fecha: {Fecha.ToShortDateString()}, Hora: {Hora}");
        Cliente.MostrarDetalles();
        Console.WriteLine("Platos:");
        foreach (var plato in ListaPlatos)
        {
            plato.MostrarDetalles();
        }
        Console.WriteLine($"Total: {Total:C}");
    }
}
