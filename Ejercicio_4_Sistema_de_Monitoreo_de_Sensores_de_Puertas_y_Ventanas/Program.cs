using System;

SensorMonitoreo sensor = new SensorMonitoreo();

ServicioAlarma alarma = new ServicioAlarma();

ServicioRegistroIncidencias registro = new ServicioRegistroIncidencias();

// Suscribimos los métodos al evento
sensor.AlertaIntruso += alarma.ActivarAlarma;

sensor.AlertaIntruso += registro.RegistrarIncidencia;

// Comprobamos la apertura de una puerta
sensor.ComprobarApertura("Puerta principal", 23);
