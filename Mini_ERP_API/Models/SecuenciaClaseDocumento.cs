using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class SecuenciaClaseDocumento
{
    public string TipoDocumentos { get; set; } = null!;

    public string ClaseD1 { get; set; } = null!;

    public string ClaseD2 { get; set; } = null!;

    public string ClaseD3 { get; set; } = null!;

    public string? ClaseD4 { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }
}
