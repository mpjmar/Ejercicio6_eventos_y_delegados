using System;

public class ServicioNotificacion
{
    public void EnviarNotificacion(object? sender, EnergiaEventArgs e)
    {
        Console.WriteLine("¡AVISO! CONSUMO EXCESIVO DE ENERGÍA");
        Console.WriteLine($"Consumo actual: {e.ConsumoActual} W");
        Console.WriteLine($"Umbral máximo: {e.Umbral} W");

        Console.WriteLine("\n-------------------------\n");
    }
}
