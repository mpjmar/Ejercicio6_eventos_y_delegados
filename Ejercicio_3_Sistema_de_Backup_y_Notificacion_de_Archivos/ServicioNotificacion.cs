using System;

public class ServicioNotificacion
{
    public void EnviarNotificacion(object? sender, BackupEventArgs e)
    {
        Console.WriteLine("NOTIFICACIÓN: Copia de seguridad completada.");
        Console.WriteLine($"Archivo: {e.NombreArchivo}");
        Console.WriteLine($"Fecha: {e.Fecha}");

        Console.WriteLine("\n----------------------\n");
    }
}
