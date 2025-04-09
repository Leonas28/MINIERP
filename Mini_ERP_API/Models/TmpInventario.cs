using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class TmpInventario
{
    public string? IdMateiral { get; set; }

    public string? Proveedor { get; set; }

    public string? Descripcion { get; set; }

    public int? Existencia { get; set; }

    public int? Linea { get; set; }
}
