using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class RecepcionFacturaDetalle
{
    public string? IdFactura { get; set; }

    public int? Posicion { get; set; }

    public string? Articulo { get; set; }

    public string? Valorunitario { get; set; }

    public string? Importe { get; set; }
}
