using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class FacturasRecibidasPortalDetalle
{
    public string IdOrden { get; set; } = null!;

    public Guid Uuid { get; set; }

    public int Partida { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Monto { get; set; }

    public decimal? Iva { get; set; }

    public string? Estatus { get; set; }
}
