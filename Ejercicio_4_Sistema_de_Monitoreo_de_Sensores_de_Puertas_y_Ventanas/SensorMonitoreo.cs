using System;

public class SensorMonitoreo
{
    public event EventHandler<IntrusoEventArgs>? AlertaIntruso;

    public void ComprobarApertura(string nombreSensor, int horaActual)
    {
        if (horaActual < 8 || horaActual >= 22)
        {
            IntrusoEventArgs datos = new IntrusoEventArgs(
                nombreSensor,
                DateTime.Now
            );

            AlertaIntruso?.Invoke(this, datos);
        }
    }
}
