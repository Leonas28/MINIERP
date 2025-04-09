using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class SolicitudCompra
{
    public string IdSolicitud { get; set; } = null!;

    public string? FechaHoraOrden { get; set; }

    public string? Empresa { get; set; }

    public string? FechaEntrega { get; set; }

    public string? IdSolicitante { get; set; }

    public string? Estatus { get; set; }

    public string? TipoDocumento { get; set; }

    public string? IdOrganizacion { get; set; }
}
