using System;

public class GestorBackups
{
    public event EventHandler<BackupEventArgs>? BackupCompletado;

    public void RealizarBackup(string nombreArchivo)
    {
        Console.WriteLine($"Realizando copia de seguridad de {nombreArchivo}...");

        BackupEventArgs datos = new BackupEventArgs(nombreArchivo, DateTime.Now);

        BackupCompletado?.Invoke(this, datos);
    }
}

