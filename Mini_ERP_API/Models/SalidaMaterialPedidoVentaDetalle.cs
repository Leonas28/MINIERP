using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class SalidaMaterialPedidoVentaDetalle
{
    public string IdSalidaMaterial { get; set; } = null!;

    public string IdPedidoVentas { get; set; } = null!;

    public int Posicion { get; set; }

    public int? CantidaPicking { get; set; }

    public string? Umpicking { get; set; }

    public bool? Estatus { get; set; }
}
