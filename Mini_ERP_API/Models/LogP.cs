using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class LogP
{
    public DateTime? Fecha { get; set; }

    public TimeSpan? Hora { get; set; }

    public string? Ins { get; set; }

    public string? Tipo { get; set; }

    public string? Proceso { get; set; }

    public string? Usuario { get; set; }

    public string? Prioridad { get; set; }

    public string? IdMensaje { get; set; }

    public string? Mensaje { get; set; }
}
