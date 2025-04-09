using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class ComplementoPago
{
    public string? IdComplemeto { get; set; }

    public string? FolioFiscalComplemento { get; set; }

    public string? Rfcemisor { get; set; }

    public string? Rfcreceptor { get; set; }

    public DateTime? FechaTimbrado { get; set; }

    public TimeSpan? HoraTimbrado { get; set; }

    public string? Xmlcomplemento { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioCancelacion { get; set; }

    public DateTime? FechaCancelacion { get; set; }

    public TimeSpan? HoraCancelacion { get; set; }

    public decimal? PagoRecibido { get; set; }

    public decimal? Saldo { get; set; }

    public DateTime? FechaPago { get; set; }

    public TimeSpan? HoraPago { get; set; }

    public string? Estatus { get; set; }
}
