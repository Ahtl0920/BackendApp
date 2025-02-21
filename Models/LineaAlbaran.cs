using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Api.Models
{
    [Table("DETALLEALBARAN")] // mapeo correcto de la tabla
    public class LineaAlbaran
    {
        [Key]
        [Column("IDLIN")]  // IDLIN: Identificador único de la línea
        public int Id { get; set; }

        [Column("IDALBV")]  // IDALBV: Relación con Albarán
        public int AlbaranId { get; set; }

        //  Datos del Artículo
        [Column("CODART")]
        public string CodigoArticulo { get; set; } = string.Empty;

        [Column("UNIDADES")]
        public int Unidades { get; set; }

        [Column("EXT0_ESTADO")]
        public string Estado { get; set; } = string.Empty;

        [Column("EXT0_MARCA")]
        public string Marca { get; set; } = string.Empty;

        [Column("EXT0_MODELO")]
        public string Modelo { get; set; } = string.Empty;

        [Column("EXT0_REFERENCIA")]
        public string Referencia { get; set; } = string.Empty;

        [Column("EXT0_BULTOS")]
        public int Bultos { get; set; }

        [Column("EXT0_LARGO")]
        public decimal Largo { get; set; }

        [Column("EXT0_ANCHO")]
        public decimal Ancho { get; set; }

        [Column("EXT0_ALTO")]
        public decimal Alto { get; set; }

        [Column("EXT0_PESO")]
        public decimal Peso { get; set; }

        [Column("EXT0_CONTENIDO")]
        public string Contenido { get; set; } = string.Empty;

        [Column("NUMSERIE")]
        public string NumeroSerie { get; set; } = string.Empty;

        //  Relación con Albarán ( Anula temporalmente si no está lista en la BD)
        [ForeignKey("AlbaranId")]
        [NotMapped]  // Si aún no existe en la base de datos, coméntar cuando sea necesario
        public Albaran? Albaran { get; set; }
    }
}
