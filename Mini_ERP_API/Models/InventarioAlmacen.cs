using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class InventarioAlmacen
{
    public string? IdAlmacen { get; set; }

    public string? IdMaterial { get; set; }

    public int? Cantidad { get; set; }

    public string? Ubicacion { get; set; }
}
