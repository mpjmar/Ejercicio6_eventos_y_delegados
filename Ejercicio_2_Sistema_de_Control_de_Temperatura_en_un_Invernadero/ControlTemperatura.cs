using System;

public class ControlTemperatura
{
    public event EventHandler<TemperaturaEventArgs> TemperaturaAlta;

    public void ComprobarTemperatura(double temperaturaActual, double umbral)
    {
        if (temperaturaActual > umbral)
        {
            TemperaturaEventArgs datos = new TemperaturaEventArgs(temperaturaActual, umbral);

            TemperaturaAlta?.Invoke(this, datos);
        }
    }
}

