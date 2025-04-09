using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class CClaveUnidad
{
    public string IdClave { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }
}
