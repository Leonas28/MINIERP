using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class ArchivosEmpresa
{
    public string IdEmpresa { get; set; } = null!;

    public string? Certificado { get; set; }

    public string? Llave { get; set; }

    public string? Password { get; set; }
}
