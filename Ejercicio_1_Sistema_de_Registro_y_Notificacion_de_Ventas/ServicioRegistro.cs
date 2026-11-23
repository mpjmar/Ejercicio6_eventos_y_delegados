using System;

public class ServicioRegistro
{
    public void RegistrarVenta(object sender, VentaEventArgs e)
    {
        Console.WriteLine("VENTA REGISTRADA");
        Console.WriteLine($"Producto: {e.Producto}");
        Console.WriteLine($"Precio: {e.Precio} euros");

        Console.WriteLine("\n---------------------------\n");
    }
}
