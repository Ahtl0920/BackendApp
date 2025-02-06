using System.Collections.Generic;

namespace MauiApp1.Api.Models
{
    public class Repartidor
    {
        public int Id { get; set; } // Identificador único del repartidor.
        public string Nombre { get; set; } = string.Empty; // Nombre del repartidor.
        public string Apellidos { get; set; } = string.Empty; // Apellidos del repartidor.
        public string Telefono { get; set; } = string.Empty; // Teléfono de contacto del repartidor.
        public string DNI { get; set; } = string.Empty; // Documento de identidad del repartidor.
        public string MatriculaVehiculo { get; set; } = string.Empty; // Matrícula del vehículo asignado.
        public string EmpresaTransporte { get; set; } = string.Empty; // Nombre de la empresa de transporte.

        //  Relación con los albaranes (asumiendo que un repartidor puede manejar varios albaranes)
        public List<Albaran> Albaranes { get; set; } = new();
    }
}
