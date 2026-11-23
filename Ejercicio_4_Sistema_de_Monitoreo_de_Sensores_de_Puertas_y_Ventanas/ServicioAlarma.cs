using System;

public class ServicioAlarma
{
    public void ActivarAlarma(object? sender, IntrusoEventArgs e)
    {
        Console.WriteLine("¡¡ALERTA DE INTRUSIÓN!!");
        Console.WriteLine($"Sensor activado: {e.NombreSensor}");
        Console.WriteLine($"Hora de detección: {e.HoraDeteccion}");

        Console.WriteLine("\n---------------------\n");
    }
}
