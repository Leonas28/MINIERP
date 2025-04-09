using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class PagoFactura
{
    public string? IdPago { get; set; }

    public string? IdRecepcion { get; set; }

    public Guid? Uuidfactura { get; set; }

    public string? IdOrden { get; set; }

    public decimal? Pago { get; set; }

    public decimal? Saldo { get; set; }

    public TimeSpan? Hora { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Parcialidad { get; set; }

    public string? Estatus { get; set; }

    public Guid? Uuidcomplemento { get; set; }

    public string? Xmlcomplemento { get; set; }
}
