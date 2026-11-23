using System;

GestorBackups gestor = new GestorBackups();

ServicioNotificacion notificacion = new ServicioNotificacion();

ServicioLog registro = new ServicioLog();

// Suscribimos los métodos al evento
gestor.BackupCompletado += notificacion.EnviarNotificacion;

gestor.BackupCompletado += registro.RegistrarBackup;

// Realizamos una copia de seguridad
gestor.RealizarBackup("documento.pdf");
