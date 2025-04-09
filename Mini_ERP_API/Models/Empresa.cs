using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Empresa
{
    public string Clave { get; set; } = null!;

    public string? RazonSocial { get; set; }

    public string? Rfc { get; set; }

    public string? Calle { get; set; }

    public string? Numero { get; set; }

    public int? IdCtlColonias { get; set; }

    public string? IdCuentasContables { get; set; }

    public string? RegimenFiscal { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }

    public string? Pais { get; set; }
}
