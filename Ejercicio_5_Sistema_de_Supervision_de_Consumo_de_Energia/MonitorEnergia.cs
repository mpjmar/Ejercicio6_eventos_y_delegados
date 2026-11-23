using System;

public class MonitorEnergia
{
    public event EventHandler<EnergiaEventArgs>? ConsumoExcesivoDetectado;

    public void ComprobarConsumo(double consumoActual, double umbral)
    {
        if (consumoActual > umbral)
        {
            EnergiaEventArgs datos = new EnergiaEventArgs(consumoActual, umbral);

            ConsumoExcesivoDetectado?.Invoke(this, datos);
        }
    }
}
