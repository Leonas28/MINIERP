using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class PedidoVentaCondicione
{
    public string IdPedidoVentas { get; set; } = null!;

    public int IdPosicion { get; set; }

    public string IdCondicion { get; set; } = null!;

    public decimal? Valor { get; set; }

    public bool? Estatus { get; set; }
}
