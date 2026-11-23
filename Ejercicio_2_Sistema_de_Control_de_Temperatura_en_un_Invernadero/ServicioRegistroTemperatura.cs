using System;

public class ServicioRegistroTemperatura
{
    public void RegistrarTemperatura(object sender, TemperaturaEventArgs e)
    {
        Console.WriteLine("REGISTRO DE TEMPERATURA");
        Console.WriteLine($"Temperatura registrada: {e.TemperaturaActual} °C");
        Console.WriteLine($"Umbral establecido: {e.Umbral} °C");

        Console.WriteLine("\n-------------------------------------\n");
    }
}

