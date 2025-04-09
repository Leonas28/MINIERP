using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class TransporteInterno
{
    public string IdTransporte { get; set; } = null!;

    public string? NombreChofer { get; set; }

    public string? Placas { get; set; }

    public decimal? CostoTag { get; set; }

    public decimal? CostoGasolina { get; set; }

    public decimal? CostoCaseta { get; set; }

    public decimal? EfectivoExtra { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }
}
