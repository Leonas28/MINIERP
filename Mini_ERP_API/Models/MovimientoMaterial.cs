using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class MovimientoMaterial
{
    public int Id { get; set; }

    public string? Movimiento { get; set; }

    public string? DocumentoFuente { get; set; }

    public string? IdMaterial { get; set; }

    public int? Cantidad { get; set; }

    public string? UnidadMedida { get; set; }

    public string? Lote { get; set; }

    public DateTime? Caducidad { get; set; }

    public DateTime? Fecha { get; set; }

    public TimeSpan? Hora { get; set; }

    public string? Usuario { get; set; }

    public string? AlmacenOrigen { get; set; }

    public string? AlmacenDestino { get; set; }

    public string? MotivoCancelacion { get; set; }
}
