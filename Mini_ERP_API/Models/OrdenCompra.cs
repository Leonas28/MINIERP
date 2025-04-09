using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class OrdenCompra
{
    public string IdOrden { get; set; } = null!;

    public string? IdTipoDocumento { get; set; }

    public string? IdPedido { get; set; }

    public string? FechaHora { get; set; }

    public string? Empresa { get; set; }

    public string? Provedor { get; set; }

    public decimal? TotalOrden { get; set; }

    public string? FechaEntrega { get; set; }

    public string? CondicionPago { get; set; }

    public string? CentroCosto { get; set; }

    public int? LugarEntrega { get; set; }

    public string? Solicitante { get; set; }

    public string? Estatus { get; set; }

    public string? IdUsuario { get; set; }

    public bool? Autorizacion { get; set; }

    public string? MotivoCancelacion { get; set; }

    public string? IdOrganizacion { get; set; }
}
