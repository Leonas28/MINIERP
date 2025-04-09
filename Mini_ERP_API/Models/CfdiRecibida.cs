using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class CfdiRecibida
{
    public string CfdiRecRfc { get; set; } = null!;

    public string CfdiEmiRfc { get; set; } = null!;

    public Guid CfdiRecUuid { get; set; }

    public DateTime CfdiRecFechaHoraRecepcion { get; set; }

    public string? CfdiRecSerie { get; set; }

    public string? CfdiRecFolio { get; set; }

    public DateTime CfdiRecFechaHoraEmision { get; set; }

    public decimal CfdiRecTotal { get; set; }

    public string? CfdiRecXml { get; set; }

    public DateTime? CfdiRecCancelacion { get; set; }

    public string CfdiRecEstatus { get; set; } = null!;

    public int? CfdiRecContrarecibo { get; set; }

    public string? CfdiRecMotivoRechazo { get; set; }

    public string? CfdiRecTipo { get; set; }
}
