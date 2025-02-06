using MauiApp1.Api.Models;

namespace MauiApp1.Api.Models
{
    public class Mercancia
    {
        public int Id { get; set; } // Identificador único de la mercancía.

        //  Descripción General
        public required string Descripcion { get; set; } // Descripción de la mercancía.
        public int Cantidad { get; set; } // Cantidad de mercancías.

        //  Datos del Artículo
        public string CodigoArticulo { get; set; } = string.Empty; // Código del artículo.
        public string Estado { get; set; } = string.Empty; // Estado de la mercancía (ejemplo: embalado, protegido).
        public string Marca { get; set; } = string.Empty; // Marca de la mercancía.
        public string Modelo { get; set; } = string.Empty; // Modelo de la mercancía.
        public string Referencia { get; set; } = string.Empty; // Referencia de la mercancía.
        public int Bultos { get; set; } // Número de bultos relacionados.
        public decimal Largo { get; set; } // Largo de la mercancía.
        public decimal Ancho { get; set; } // Ancho de la mercancía.
        public decimal Alto { get; set; } // Alto de la mercancía.
        public decimal Peso { get; set; } // Peso de la mercancía.
        public string Contenido { get; set; } = string.Empty; // Descripción del contenido.
        public string NumeroSerie { get; set; } = string.Empty; // Número de serie del artículo.

        //  Relaciones
        public int AlbaranId { get; set; } // ID del albarán al que pertenece la mercancía.
        public required Albaran Albaran { get; set; } // Relación con el albarán.
    }
}
