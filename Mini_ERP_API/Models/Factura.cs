using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Factura
{
    public string IdFactura { get; set; } = null!;

    public string? IdClaseDocumento { get; set; }

    public DateTime? FechaTimbrado { get; set; }

    public TimeSpan? HoraTimbrado { get; set; }

    public Guid? FolioFiscal { get; set; }

    public string? Sello { get; set; }

    public string? Timbrado { get; set; }

    public string? Xml { get; set; }

    public string? Estatus { get; set; }

    public string? SelloSat { get; set; }

    public string? NoCertificadoSat { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioCancelacion { get; set; }

    public DateTime? FechaCancelacion { get; set; }

    public TimeSpan? HoraCancelacion { get; set; }

    public string? PrecioFacturado { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Iva { get; set; }
}
