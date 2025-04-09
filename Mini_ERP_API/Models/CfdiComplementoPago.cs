using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class CfdiComplementoPago
{
    public Guid ComUuidfactura { get; set; }

    public Guid ComUuidcomplemento { get; set; }

    public string? ComXmlcomplemento { get; set; }

    public decimal? ComPago { get; set; }

    public int ComParcialidad { get; set; }

    public decimal? ComSaldo { get; set; }

    public DateTime? ComFecha { get; set; }

    public TimeSpan? ComHora { get; set; }

    public string ComRfcemisor { get; set; } = null!;
}
