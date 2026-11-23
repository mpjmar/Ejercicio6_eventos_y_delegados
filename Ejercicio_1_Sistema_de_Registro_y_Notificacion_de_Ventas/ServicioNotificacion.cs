using System;

public class ServicioNotificacion
{
    public void EnviarNotificacionVenta(object sender, VentaEventArgs e)
    {
        Console.WriteLine("NOTIFICACIÓN AL USUARIO");
        Console.WriteLine($"Se ha vendido: {e.Producto}");
        Console.WriteLine($"Precio: {e.Precio} euros");

        Console.WriteLine("\n---------------------------\n");
    }
}


