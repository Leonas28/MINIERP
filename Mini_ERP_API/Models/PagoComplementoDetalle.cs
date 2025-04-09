using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class PagoComplementoDetalle
{
    public string? IdComplemento { get; set; }

    public string? FolioFiscal { get; set; }

    public int? Parcialidad { get; set; }

    public decimal? Pago { get; set; }

    public decimal? SaldoAnterior { get; set; }

    public decimal? SaldoInsoluto { get; set; }

    public string? Estatus { get; set; }
}
