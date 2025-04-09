using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class FacturaDetalle
{
    public string IdFactura { get; set; } = null!;

    public int IdPosicion { get; set; }

    public string? IdMaterial { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Valor { get; set; }

    public string IdSalidaMaterial { get; set; } = null!;
}
