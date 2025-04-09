using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class CentroCosto
{
    public string IdCentroCostos { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? IdCentroSuministro { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }

    public DateTime? FechaValidez { get; set; }
}
