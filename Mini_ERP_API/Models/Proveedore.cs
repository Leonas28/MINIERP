using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Proveedore
{
    public string Clave { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Calle { get; set; }

    public string? Numero { get; set; }

    public int? IdColonia { get; set; }

    public string? Telefono { get; set; }

    public string? Extension { get; set; }

    public string? EMail { get; set; }

    public string? Rfc1 { get; set; }

    public string? Rfc2 { get; set; }

    public int? IdBanco { get; set; }

    public string? CuentaBancaria { get; set; }

    public string? IdViaDePago { get; set; }

    public string? CondicionPago { get; set; }

    public string? Estatus { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public TimeSpan? HoraCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }

    public string? Pais { get; set; }

    public string? Idioma { get; set; }
}
