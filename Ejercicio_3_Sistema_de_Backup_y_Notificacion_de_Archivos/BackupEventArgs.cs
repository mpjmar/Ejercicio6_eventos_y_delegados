using System;

public class BackupEventArgs : EventArgs
{
    public string NombreArchivo { get; set; }
    public DateTime Fecha { get; set; }

    public BackupEventArgs(string nombreArchivo, DateTime fecha)
    {
        NombreArchivo = nombreArchivo;
        Fecha = fecha;
    }
}

