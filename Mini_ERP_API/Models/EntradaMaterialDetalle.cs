using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class EntradaMaterialDetalle
{
    public string? IdEntradaMaterial { get; set; }

    public string? IdOrden { get; set; }

    public int? Posicion { get; set; }

    public string? IdMaterial { get; set; }

    public string? Descripcion { get; set; }

    public int? CantidadRecibida { get; set; }

    public string? Umrecibida { get; set; }

    public string? Lote { get; set; }

    public string? Caducidad { get; set; }

    public string? Almacen { get; set; }

    public bool? Estatus { get; set; }

    public int? CantidadFacturada { get; set; }
}
