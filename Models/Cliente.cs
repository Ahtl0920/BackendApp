using System.Collections.Generic;

namespace MauiApp1.Api.Models
{
    public class Cliente
    {
        public int Id { get; set; } // Identificador único del cliente.
        public string CodigoCliente { get; set; } = string.Empty; // Código interno del cliente.
        public string Nombre { get; set; } = string.Empty; // Nombre del cliente.
        public string NIF { get; set; } = string.Empty; // Documento de identidad (DNI/NIF/CIF).
        public string Direccion { get; set; } = string.Empty; // Dirección del cliente.
        public string Telefono { get; set; } = string.Empty; // Teléfono del cliente.
        public string Email { get; set; } = string.Empty; // Correo electrónico del cliente.

        //  Relación con Albaranes (Un cliente puede tener varios albaranes)
        public List<Albaran> Albaranes { get; set; } = new();
    }
}


