using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class FacturaCondicione
{
    public string IdFactura { get; set; } = null!;

    public int IdPosicion { get; set; }

    public string IdCondicion { get; set; } = null!;

    public decimal? Valor { get; set; }

    public bool? Estatus { get; set; }

    public string IdSalidaMaterial { get; set; } = null!;
}
