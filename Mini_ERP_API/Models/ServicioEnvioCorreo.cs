using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class ServicioEnvioCorreo
{
    public string? Correo { get; set; }

    public string? Contraseña { get; set; }

    public string? Transaccion { get; set; }

    public string? ServidorSmt { get; set; }

    public string? Puerto { get; set; }

    public string? Estatus { get; set; }
}
