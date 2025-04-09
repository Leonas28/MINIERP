using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Carrito
{
    public int IdCarrito { get; set; }

    public int? IdUsusario { get; set; }

    public string? IdProducto { get; set; }

    public int? Cantidad { get; set; }

    public ulong? Estatus { get; set; }
}
