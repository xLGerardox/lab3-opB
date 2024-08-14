public class GestorClientes
{
    public List<Cliente> ListaClientes { get; set; } = new List<Cliente>();

    public void RegistrarClienteRegular(string nombre, string correo, string telefono)
    {
        var cliente = new ClienteRegular(nombre, correo, telefono);
        ListaClientes.Add(cliente);
    }

    public void RegistrarClienteVIP(string nombre, string correo, string telefono, float descuento)
    {
        var cliente = new ClienteVIP(nombre, correo, telefono, descuento);
        ListaClientes.Add(cliente);
    }

    public Cliente BuscarClientePorNombre(string nombre)
    {
        return ListaClientes.FirstOrDefault(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    public void MostrarClientes()
    {
        foreach (var cliente in ListaClientes)
        {
            cliente.MostrarDetalles();
            Console.WriteLine();
        }
    }
}
