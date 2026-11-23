using System;

public class VentaEventArgs : EventArgs
{
    public string Producto { get; set; }
    public decimal Precio { get; set; }

    public VentaEventArgs(string producto, decimal precio)
    {
        Producto = producto;
        Precio = precio;
    }
}
