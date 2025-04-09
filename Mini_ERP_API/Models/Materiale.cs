using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Materiale
{
    public string Clave { get; set; } = null!;

    public string? NombreCorto { get; set; }

    public string? NombreLargo { get; set; }

    public string? UnidadMedidaVenta { get; set; }

    public string? UnidadEmpaqueVenta { get; set; }

    public int? CantidadEmpaqueVenta { get; set; }

    public string? UnidadMedidaCompra { get; set; }

    public string? UnidadEmpaqueCompra { get; set; }

    public int? CantidadEmpaqueCompra { get; set; }

    public decimal? ManoObra { get; set; }

    public decimal? Pintura { get; set; }

    public byte[]? Imagen { get; set; }

    public string? CodigoEan { get; set; }

    public decimal? UltimoPrecio { get; set; }

    public string? ListaMaterial { get; set; }

    public bool? Grabado { get; set; }

    public int? TotalCaracteresgrabado { get; set; }

    public bool? Autorizacion { get; set; }

    public string? CodigoSat { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }

    public int? StockMinimo { get; set; }

    public string? TipoMaterial { get; set; }
}
