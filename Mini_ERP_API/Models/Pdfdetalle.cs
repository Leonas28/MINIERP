using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Pdfdetalle
{
    public string? Partida { get; set; }

    public string? Folio { get; set; }

    public string? Cantidad { get; set; }

    public string? Unidad { get; set; }

    public string? ClaveUnidadSat { get; set; }

    public string? ClaveServicio { get; set; }

    public string? Concepto { get; set; }

    public string? ValorUnitario { get; set; }

    public string? Impuestos { get; set; }

    public string? Importe { get; set; }
}
