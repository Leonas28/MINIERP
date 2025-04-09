using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class PedidoDetalle
{
    public int? IdPedido { get; set; }

    public string? IdProducto { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public string? Estatus { get; set; }
}
