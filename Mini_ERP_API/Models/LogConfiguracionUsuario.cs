using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class LogConfiguracionUsuario
{
    public int Consecutivo { get; set; }

    public DateTime? Fecha { get; set; }

    public TimeSpan? Hora { get; set; }

    public string? Instancia { get; set; }

    public string? Tipo { get; set; }

    public string? Proceso { get; set; }

    public string? Usuario { get; set; }

    public string? IdMensaje { get; set; }

    public string? Mensaje { get; set; }
}
