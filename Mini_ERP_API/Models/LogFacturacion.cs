using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class LogFacturacion
{
    public int Id { get; set; }

    public string? IdRemision { get; set; }

    public string? Rfc { get; set; }

    public string? RazonSocial { get; set; }

    public string? Email { get; set; }

    public string? UsuCfdi { get; set; }

    public DateTime? FechaHora { get; set; }

    public string? Estatus { get; set; }

    public string? Tipo { get; set; }

    public string? IdFactura { get; set; }
}
