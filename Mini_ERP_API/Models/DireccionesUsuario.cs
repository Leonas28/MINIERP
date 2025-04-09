using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class DireccionesUsuario
{
    public int IdDireccion { get; set; }

    public int? IdUsuario { get; set; }

    public string? Estado { get; set; }

    public string? Nombre { get; set; }

    public string? Apelldios { get; set; }

    public string? Calle { get; set; }

    public string? NoExt { get; set; }

    public string? NoInt { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Colonia { get; set; }

    public string? EntreCalles { get; set; }

    public string? Referencias { get; set; }

    public string? TelefonoMovil { get; set; }

    public string? TelefonoFijo { get; set; }
}
