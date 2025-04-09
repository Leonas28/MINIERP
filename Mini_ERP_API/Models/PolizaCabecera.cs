using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class PolizaCabecera
{
    public string? NoDoc { get; set; }

    public string? Empresa { get; set; }

    public DateTime? Año { get; set; }

    public string? Periodo { get; set; }

    public string? TipoDoc { get; set; }

    public string? Moneda { get; set; }

    public string? DocComp { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaContabilizacion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? HoraRegistro { get; set; }

    public string? Estatus { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdRecepcion { get; set; }

    public int? IdPoliza { get; set; }
}
