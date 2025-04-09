using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class MaterialesFabricadosAlmacene
{
    public string IdMaterial { get; set; } = null!;

    public string IdAlmacenFabricacion { get; set; } = null!;

    public string IdAlmacen { get; set; } = null!;

    public string? Estatus { get; set; }

    public string? UsuariCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }
}
