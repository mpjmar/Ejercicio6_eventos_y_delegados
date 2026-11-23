
ControlTemperatura control = new ControlTemperatura();

ServicioAlerta alerta = new ServicioAlerta();

ServicioRegistroTemperatura registro = new ServicioRegistroTemperatura();

// Suscribimos los métodos al evento
control.TemperaturaAlta += alerta.EnviarAlerta;

control.TemperaturaAlta += registro.RegistrarTemperatura;

// Comprobamos la temperatura
control.ComprobarTemperatura(35, 30);

