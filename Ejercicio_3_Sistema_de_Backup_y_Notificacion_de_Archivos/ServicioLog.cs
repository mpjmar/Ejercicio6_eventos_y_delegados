using System;

public class ServicioLog
{
    public void RegistrarBackup(object? sender, BackupEventArgs e)
    {
        Console.WriteLine("REGISTRO DE BACKUP");
        Console.WriteLine($"Archivo respaldado: {e.NombreArchivo}");
        Console.WriteLine($"Fecha del backup: {e.Fecha}");

        Console.WriteLine("\n----------------------\n");
    }
}
