using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class CatUsuario
{
    public string UsuId { get; set; } = null!;

    public string UsuClave { get; set; } = null!;

    public string UsuNombre { get; set; } = null!;

    public string? UsuRfc { get; set; }

    public string? UsuCorreo { get; set; }

    public string UsuTipo { get; set; } = null!;

    public string UsuEstatus { get; set; } = null!;

    public string? UsuActivo { get; set; }

    public string? UsuFechaHora { get; set; }
}
