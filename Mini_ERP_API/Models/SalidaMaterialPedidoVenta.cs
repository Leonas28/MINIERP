using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class SalidaMaterialPedidoVenta
{
    public string IdSalidaMaterial { get; set; } = null!;

    public string? IdPedidoVentas { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public DateTime? FechaPicking { get; set; }

    public string? IdAlmacen { get; set; }

    public string? Estatus { get; set; }

    public bool? Contabilizado { get; set; }

    public string? UsuarioCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }
}
