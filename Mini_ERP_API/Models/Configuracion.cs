using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Configuracion
{
    public string? Clave { get; set; }

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }

    public string? Descripcion { get; set; }

    public string? Valor { get; set; }
}
