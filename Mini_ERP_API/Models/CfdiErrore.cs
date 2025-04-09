using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class CfdiErrore
{
    public int Id { get; set; }

    public DateTime Hora { get; set; }

    public string? Error { get; set; }
}
