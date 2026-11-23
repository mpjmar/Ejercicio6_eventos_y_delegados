using System;

public class TemperaturaEventArgs : EventArgs
{
    public double TemperaturaActual { get; set; }
    public double Umbral { get; set; }

    public TemperaturaEventArgs(double temperaturaActual, double umbral)
    {
        TemperaturaActual = temperaturaActual;
        Umbral = umbral;
    }
}

