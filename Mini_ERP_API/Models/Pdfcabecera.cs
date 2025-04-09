using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Pdfcabecera
{
    public string? Folio { get; set; }

    public string? Nombre { get; set; }

    public string? Rfcemisor { get; set; }

    public string? TipoComprobante { get; set; }

    public string? Lugar { get; set; }

    public string? RegimenFiscal { get; set; }

    public string? FormaPago { get; set; }

    public string? MetodoPago { get; set; }

    public string? Moneda { get; set; }

    public string? Fecha { get; set; }

    public string? NoPedido { get; set; }

    public string? Rfcreceptor { get; set; }

    public string? Cliente { get; set; }

    public string? Domicilio { get; set; }

    public string? UsoCfdi { get; set; }

    public string? Subtotal { get; set; }

    public string? Descuentos { get; set; }

    public string? ImpTrasladados { get; set; }

    public string? ImpRetenidos { get; set; }

    public string? Total { get; set; }

    public string? TotalLetra { get; set; }

    public string? Observaciones { get; set; }

    public string? Cfdirelacion { get; set; }

    public string? TipoRelacion { get; set; }

    public string? Cfdirelacionado { get; set; }

    public string? CerEmisor { get; set; }

    public string? Uuid { get; set; }

    public string? CerSat { get; set; }

    public string? FechaHora { get; set; }

    public string? SelloDigital { get; set; }

    public string? SelloSat { get; set; }

    public string? CadenaOriginal { get; set; }
}
