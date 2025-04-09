using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class ListaMaterial
{
    public string? ListaId { get; set; }

    public string? IdMaterial { get; set; }

    public int? Cantidad { get; set; }

    public string? Um { get; set; }

    public decimal? Costo { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }
}
