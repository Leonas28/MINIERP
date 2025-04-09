using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Precio
{
    public string Clave { get; set; } = null!;

    public string IdMaterial { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public DateTime Vigencia { get; set; }

    public bool? Estatus { get; set; }

    public decimal? PrecioLista { get; set; }

    public decimal? PrecioMostrador { get; set; }

    public decimal? PrecioInternet { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }
}
