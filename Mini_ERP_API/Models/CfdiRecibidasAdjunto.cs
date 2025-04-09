using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class CfdiRecibidasAdjunto
{
    public string CfdiRecRfc { get; set; } = null!;

    public string CfdiEmiRfc { get; set; } = null!;

    public Guid CfdiRecUuid { get; set; }

    public int CfdiRecAdjIndex { get; set; }

    public string CfdiRecAdjRuta { get; set; } = null!;

    public string CfdiRecAdjEstatus { get; set; } = null!;

    public string? NombreReal { get; set; }

    public byte[]? Archivo { get; set; }
}
