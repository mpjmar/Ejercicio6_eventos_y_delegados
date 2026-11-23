using System;

MonitorEnergia monitor = new MonitorEnergia();

ServicioNotificacion notificacion = new ServicioNotificacion();

ServicioAjusteAutomatizado ajuste = new ServicioAjusteAutomatizado();

// Suscribimos los métodos al evento
monitor.ConsumoExcesivoDetectado += notificacion.EnviarNotificacion;

monitor.ConsumoExcesivoDetectado += ajuste.ReducirConsumo;

// Comprobamos el consumo eléctrico
monitor.ComprobarConsumo(8500, 7000);
