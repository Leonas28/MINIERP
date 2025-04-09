using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class UbicacionesEntrega
{
    public int Id { get; set; }

    public int? IdUsuario { get; set; }

    public float? Latitud { get; set; }

    public float? Longitud { get; set; }

    public bool? Estatus { get; set; }
}
