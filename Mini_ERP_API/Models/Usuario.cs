using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Usuario1 { get; set; }

    public string? EmailUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public string? ApellidoPaternoUsuario { get; set; }

    public string? ApellidoMaternoUsuario { get; set; }

    public string? PasswordUsuario { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }

    public string? Telefono { get; set; }

    public string? Activo { get; set; }

    public DateTime? FechaAcceso { get; set; }

    public TimeSpan? HoraAcceso { get; set; }
}
