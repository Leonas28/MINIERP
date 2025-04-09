using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class EntradaMaterialCabecera
{
    public string? IdEntradaMaterial { get; set; }

    public string? IdTipoDocumento { get; set; }

    public string? IdOrden { get; set; }

    public string? FechaHora { get; set; }

    public string? Estatus { get; set; }

    public string? Usuario { get; set; }
}
