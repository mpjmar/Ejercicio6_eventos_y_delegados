using System;

public class IntrusoEventArgs : EventArgs
{
    public string NombreSensor { get; set; }
    public DateTime HoraDeteccion { get; set; }

    public IntrusoEventArgs(string nombreSensor, DateTime horaDeteccion)
    {
        NombreSensor = nombreSensor;
        HoraDeteccion = horaDeteccion;
    }
}
