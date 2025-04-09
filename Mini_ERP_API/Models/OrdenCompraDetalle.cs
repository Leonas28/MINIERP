using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class OrdenCompraDetalle
{
    public string IdOrden { get; set; } = null!;

    public int Posicion { get; set; }

    public string? IdMaterial { get; set; }

    public string? Material { get; set; }

    public string? Descripcion { get; set; }

    public int? Cantidad { get; set; }

    public string? Um { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Monto { get; set; }

    public string? Estatus { get; set; }
}
