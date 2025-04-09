using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class DireccionesEntrega
{
    public int IdDireccion { get; set; }

    public string? IdCliente { get; set; }

    public string? Calle { get; set; }

    public string? NumeroExt { get; set; }

    public string? NumeroInt { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Colonia { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }

    public int? IdColonia { get; set; }

    public string? Alias { get; set; }
}
