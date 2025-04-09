using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class TransporteInternoDetalle
{
    public string? IdTransporte { get; set; }

    public string? IdSalidaMaterial { get; set; }

    public int? Posicion { get; set; }

    public int? Cantidad { get; set; }
}
