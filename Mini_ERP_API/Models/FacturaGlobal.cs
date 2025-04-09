using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class FacturaGlobal
{
    public string? IdFactura { get; set; }

    public DateTime? Fecha1 { get; set; }

    public DateTime? Fecha2 { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Fecha { get; set; }

    public TimeSpan? Hora { get; set; }
}
