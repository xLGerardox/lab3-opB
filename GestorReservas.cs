public class GestorReservas
{
    public List<Reserva> ListaReservas { get; set; } = new List<Reserva>();

    public void RegistrarReserva(int numeroReserva, DateTime fecha, TimeSpan hora, Cliente cliente, List<Plato> platos)
    {
        var reserva = new Reserva(numeroReserva, fecha, hora, cliente);
        reserva.ListaPlatos.AddRange(platos);
        reserva.CalcularTotal();
        ListaReservas.Add(reserva);
    }

    public Reserva BuscarReservaPorNumero(int numeroReserva)
    {
        return ListaReservas.FirstOrDefault(r => r.NumeroReserva == numeroReserva);
    }

    public void MostrarReservas()
    {
        foreach (var reserva in ListaReservas)
        {
            reserva.MostrarDetalles();
            Console.WriteLine();
        }
    }
}
