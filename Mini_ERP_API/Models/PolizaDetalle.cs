using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class PolizaDetalle
{
    public string? NoDoc { get; set; }

    public decimal? Posicion { get; set; }

    public decimal? Cargo { get; set; }

    public string? CuentaContable { get; set; }

    public decimal? Monto { get; set; }

    public decimal? CentroCosto { get; set; }

    public decimal? CentroBeneficio { get; set; }

    public string? Estatus { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdRecepcion { get; set; }

    public int? IdPoliza { get; set; }
}
