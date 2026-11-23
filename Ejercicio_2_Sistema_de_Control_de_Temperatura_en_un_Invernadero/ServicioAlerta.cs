using System;

public class ServicioAlerta
{
    public void EnviarAlerta(object sender, TemperaturaEventArgs e)
    {
        Console.WriteLine("¡ALERTA! Temperatura demasiado alta.");
        Console.WriteLine($"Temperatura actual: {e.TemperaturaActual} °C");
        Console.WriteLine($"Umbral máximo: {e.Umbral} °C");

        Console.WriteLine("\n-------------------------------------\n");
    }
}

