using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class LogCorreo
{
    public int Id { get; set; }

    public string? Documento { get; set; }

    public string? TipoDocumento { get; set; }

    public string? Destinatario { get; set; }

    public string? Mensaje { get; set; }

    public string? Estatus { get; set; }

    public DateTime? FechaHora { get; set; }
}
