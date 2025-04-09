using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class PedidoVentaArticulo
{
    public string IdPedidoVentas { get; set; } = null!;

    public int Posicion { get; set; }

    public string? IdMaterial { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Monto { get; set; }

    public string? IdCentroBeneficio { get; set; }

    public bool? Estatus { get; set; }
}
