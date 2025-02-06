using MauiApp1.Api.Models;

namespace MauiApp1.Api.Models
{
    public class Albaran
    {
        public int Id { get; set; } // IDALBV: Identificador del albarán.
        public string Serie { get; set; } = string.Empty; // SERIE: Serie del albarán.
        public int NumDoc { get; set; } // NUMDOC: Número de documento del albarán.

        //  Datos de Origen
        public string CodRemitente { get; set; } = string.Empty; // EXT0_OREMITENTE
        public string RazonRemitente { get; set; } = string.Empty; // EXT0_ORAZONREMITENTE
        public string Observaciones { get; set; } = string.Empty; // EXT0_OSOBSERVACIONES
        public DateTime FechaEfecto { get; set; } // EXT0_OFECHAEFECTO
        public string HoraLlegada { get; set; } = string.Empty; // EXT0_OHORADELLEGADA
        public string HoraSalida { get; set; } = string.Empty; // EXT0_OHORADESALIDA
        public string HoraLlegada2 { get; set; } = string.Empty; // EXT0_OHORADELLEGADA2
        public string HoraSalida2 { get; set; } = string.Empty; // EXT0_OHORADESALIDA2

        //  Datos de Destino
        public string TipoServicio { get; set; } = string.Empty; // EXT0_DCABETIPOSERVICIO
        public string TipoTransporte { get; set; } = string.Empty; // EXT0_DESCTIPODESERVICIO
        public string Destinatario { get; set; } = string.Empty; // EXT0_DRAZONDESTINATARIO
        public string Poblacion { get; set; } = string.Empty; // EXT0_DPOBLACION
        public string Provincia { get; set; } = string.Empty; // EXT0_DNOMPROVI
        public string DocCliente { get; set; } = string.Empty; // EXT0_DDOCUMERCACLI
        public int Operarios { get; set; } // EXT0_DNUMOPERARIOS
        public string MediosEspeciales { get; set; } = string.Empty; // EXT0_DMEDIOSESPECIALES
        public string Vehiculo { get; set; } = string.Empty; // EXT0_DMVEHICULODEREP
        public string Semirremolque { get; set; } = string.Empty; // EXT0_DMSEMIRREMOLQUEREP
        public bool DcFirmada { get; set; } // EXT0_DCONFFIRMADO
        public bool DcSellada { get; set; } // EXT0_DCONFSELLADO
        public bool PendienteRevision { get; set; } // EXT0_DCONFPENDREVISION
        public string NombreRecepcionista { get; set; } = string.Empty; // EXT0_DCONFNOMBRECLI
        public string DniRecepcionista { get; set; } = string.Empty; // EXT0_DCONFDNICLI
        public bool Conforme { get; set; } // EXT0_DSICONFCLI
        public string MotivoNoConforme { get; set; } = string.Empty; // EXT0_DMOTIVONOCONFCLI

        //  Validación de Modificación
        public string ServirHojaRuta { get; set; } = string.Empty; // EXT0_DSERVIRHC
        public string HoraDeRuta { get; set; } = string.Empty; // EXT0_DHOJADERUTANUM

        //  Relación con Lineas de Albarán
        public List<LineaAlbaran> Lineas { get; set; } = new();

        //  Código para lector QR
        public string LectorCodigoBarras => $"{Serie}/{NumDoc}";
    }
}
