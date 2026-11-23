
RegistroVentas registroVentas = new RegistroVentas();

ServicioRegistro servicioRegistro = new ServicioRegistro();

ServicioNotificacion servicioNotificacion = new ServicioNotificacion();

// Suscribimos los métodos al evento
registroVentas.VentaRealizada += servicioRegistro.RegistrarVenta;

registroVentas.VentaRealizada += servicioNotificacion.EnviarNotificacionVenta;

// Procesamos una venta
registroVentas.ProcesarVenta("Teclado", 35.50m);


