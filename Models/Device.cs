using System;

namespace SmartIoTApi.Models
{
    public class Device
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // ID único
        public string Name { get; set; }               // Nombre del dispositivo
        public string Type { get; set; }               // Tipo (bombillo, ventilador, sensor)
        public bool IsOnline { get; set; } = false;    // Estado (en línea o no)
    }
}
