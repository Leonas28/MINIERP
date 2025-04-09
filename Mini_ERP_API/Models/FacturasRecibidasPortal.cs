using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class FacturasRecibidasPortal
{
    public string? Clave { get; set; }

    public string IdOrden { get; set; } = null!;

    public Guid FolioFiscal { get; set; }

    public decimal? Total { get; set; }

    public string? Xml { get; set; }

    public DateTime? Fecha { get; set; }

    public TimeSpan? Hora { get; set; }

    public string? Empresa { get; set; }

    public string? Proveedor { get; set; }

    public string? TipoFactura { get; set; }

    public string? Estatus { get; set; }

    public string? Folio { get; set; }

    public string? Serie { get; set; }

    public string? UsuarioRoa { get; set; }

    public DateTime? FechaRoa { get; set; }

    public TimeSpan? HoraRoa { get; set; }

    public string? MotivoRechazo { get; set; }
}
