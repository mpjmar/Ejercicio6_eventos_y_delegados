using System;

public class ServicioRegistroIncidencias
{
    public void RegistrarIncidencia(object? sender, IntrusoEventArgs e)
    {
        Console.WriteLine("REGISTRO DE INCIDENCIA");
        Console.WriteLine($"Sensor: {e.NombreSensor}");
        Console.WriteLine($"Fecha y hora: {e.HoraDeteccion}");

        Console.WriteLine("\n---------------------\n");
    }
}
