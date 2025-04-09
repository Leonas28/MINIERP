using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class RolesUsuario
{
    public string? IdUsuario { get; set; }

    public string? IdRol { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }
}
