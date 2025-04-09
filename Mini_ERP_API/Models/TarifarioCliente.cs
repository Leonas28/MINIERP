using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class TarifarioCliente
{
    public string? IdCliente { get; set; }

    public string? IdTarifario { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public string? HoraEliminacion { get; set; }
}
