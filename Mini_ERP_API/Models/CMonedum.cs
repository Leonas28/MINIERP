using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class CMonedum
{
    public string Clave { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? Decimales { get; set; }

    public int? PorcentajeVariacion { get; set; }
}
