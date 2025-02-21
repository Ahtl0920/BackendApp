using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Api.Models
{
    [Table("CABEALBV")] // Mapeo correcto a la tabla de SQL
    public class Albaran
    {
        [Key]
        [Column("IDALBV")]  // IDALBV: Identificador del albarán.
        public decimal Id { get; set; }

        [Column("SERIE")]
        public string Serie { get; set; } = string.Empty;

        [Column("NUMDOC")]
        public decimal NumDoc { get; set; }

        // Datos de Origen
        [Column("EXT0_OREMITENTE")]
        public string? CodRemitente { get; set; } = string.Empty;  //

        [Column("EXT0_ORAZONREMITENTE")]
        public string? RazonRemitente { get; set; } = string.Empty;

        [Column("EXT0_OSOBSERVACIONES")]
        public string? Observaciones { get; set; } = string.Empty;  //

        [Column("EXT0_OFECHAEFECTO")]
        public DateTime? FechaEfecto { get; set; }

        [Column("EXT0_OHORADELLEGADA")]
        public string HoraLlegada { get; set; } = string.Empty;

        [Column("EXT0_OHORADESALIDA")]
        public string HoraSalida { get; set; } = string.Empty;

        [Column("EXT0_OHORADELLEGADA2")]
        public string HoraLlegada2 { get; set; } = string.Empty;

        [Column("EXT0_OHORADESALIDA2")]
        public string HoraSalida2 { get; set; } = string.Empty;

        // Datos de Destino
        [Column("EXT0_DCABETIPOSERVICIO")]
        public string TipoServicio { get; set; } = string.Empty;

        [Column("EXT0_DESCTIPODESERVICIO")]
        public string TipoTransporte { get; set; } = string.Empty;

        [Column("EXT0_DRAZONDESTINATARIO")]
        public string? Destinatario { get; set; } = string.Empty;

        [Column("EXT0_DPOBLACION")]
        public string Poblacion { get; set; } = string.Empty;

        [Column("EXT0_DNOMPROVI")]
        public string Provincia { get; set; } = string.Empty;

        [Column("EXT0_DDOCUMERCACLI")]
        public string DocCliente { get; set; } = string.Empty;

        [Column("EXT0_DNUMOPERARIOS")]
        public string? Operarios { get; set; }

        [Column("EXT0_DMEDIOSESPECIALES")]
        public string MediosEspeciales { get; set; } = string.Empty;

        [Column("EXT0_DMVEHICULODEREP")]
        public string Vehiculo { get; set; } = string.Empty;

        [Column("EXT0_DMSEMIRREMOLQUEREP")]
        public string Semirremolque { get; set; } = string.Empty;

        [Column("EXT0_DCONFFIRMADO")]
        public string? DcFirmada { get; set; }

        [Column("EXT0_DCONFSELLADO")]
        public string? DcSellada { get; set; }

        [Column("EXT0_DCONFPENDREVISION")]
        public string? PendienteRevision { get; set; }

        [Column("EXT0_DCONFNOMBRECLI")]
        public string NombreRecepcionista { get; set; } = string.Empty;

        [Column("EXT0_DCONFDNICLI")]
        public string DniRecepcionista { get; set; } = string.Empty;

        [Column("EXT0_DSICONFCLI")]
        public string? Conforme { get; set; }

        [Column("EXT0_DMOTIVONOCONFCLI")]
        public string MotivoNoConforme { get; set; } = string.Empty;

        // Validación de Modificación
        [Column("EXT0_DSERVIRHC")]
        public string ServirHojaRuta { get; set; } = string.Empty;

        [Column("EXT0_DHOJADERUTANUM")]
        public string HoraDeRuta { get; set; } = string.Empty;

        // Relación con Lineas de Albarán
        public List<LineaAlbaran> Lineas { get; set; } = new();

        // Código para lector QR 
        [NotMapped]
        public string LectorCodigoBarras => $"{Serie}/{NumDoc}";
    }
}
