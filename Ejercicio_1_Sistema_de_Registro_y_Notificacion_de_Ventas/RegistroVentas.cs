using System;

public class RegistroVentas
{
    public event EventHandler<VentaEventArgs> VentaRealizada;

    public void ProcesarVenta(string producto, decimal precio)
    {
        VentaEventArgs datos = new VentaEventArgs(producto, precio);

        VentaRealizada?.Invoke(this, datos);
    }
}

