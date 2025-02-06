namespace MauiApp1.Api.Models
{
    public class LineaAlbaran
    {
        public int Id { get; set; } // IDLIN: Identificador único de la línea.
        public int AlbaranId { get; set; } // IDALBV: Relación con Albarán.

        //  Datos del Artículo
        public string CodigoArticulo { get; set; } = string.Empty; // CODART
        public int Unidades { get; set; } // UNIDADES
        public string Estado { get; set; } = string.Empty; // EXT0_ESTADO
        public string Marca { get; set; } = string.Empty; // EXT0_MARCA
        public string Modelo { get; set; } = string.Empty; // EXT0_MODELO
        public string Referencia { get; set; } = string.Empty; // EXT0_REFERENCIA
        public int Bultos { get; set; } // EXT0_BULTOS
        public decimal Largo { get; set; } // EXT0_LARGO
        public decimal Ancho { get; set; } // EXT0_ANCHO
        public decimal Alto { get; set; } // EXT0_ALTO
        public decimal Peso { get; set; } // EXT0_PESO
        public string Contenido { get; set; } = string.Empty; // EXT0_CONTENIDO
        public string NumeroSerie { get; set; } = string.Empty; // NUMSERIE

        //  Relación con Albarán
        public Albaran? Albaran { get; set; }
    }
}
