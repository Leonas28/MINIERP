using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class ErrorFactura
{
    public string IdFactura { get; set; } = null!;

    public string? MensageError { get; set; }

    public DateTime? Fecha { get; set; }

    public TimeSpan? Hora { get; set; }

    public string? Archivo { get; set; }

    public bool? Estatus { get; set; }
}
