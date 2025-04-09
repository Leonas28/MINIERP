using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class RecepciondeFacturaCabecera
{
    public string IdFactura { get; set; } = null!;

    public string? IdOrden { get; set; }

    public string? RfcEmisor { get; set; }

    public string? Uuid { get; set; }

    public string? FechadeRecepcion { get; set; }

    public string? Xml { get; set; }

    public decimal? Total { get; set; }
}
