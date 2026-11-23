using System;

public class ServicioAjusteAutomatizado
{
    public void ReducirConsumo(object? sender, EnergiaEventArgs e)
    {
        Console.WriteLine("AJUSTE AUTOMATIZADO");
        Console.WriteLine("Se ha activado el sistema de ahorro energético.");
        Console.WriteLine($"Consumo detectado: {e.ConsumoActual} W");
        Console.WriteLine("Se están aplicando medidas para reducir el consumo.");

        Console.WriteLine("\n-------------------------\n");
    }
}
