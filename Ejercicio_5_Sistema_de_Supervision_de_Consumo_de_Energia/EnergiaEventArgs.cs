using System;

public class EnergiaEventArgs : EventArgs
{
    public double ConsumoActual { get; set; }
    public double Umbral { get; set; }

    public EnergiaEventArgs(double consumoActual, double umbral)
    {
        ConsumoActual = consumoActual;
        Umbral = umbral;
    }
}
