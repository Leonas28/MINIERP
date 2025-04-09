using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Interlocutore
{
    public string Clave { get; set; } = null!;

    public string IdCliente { get; set; } = null!;

    public string? IdCliente2 { get; set; }
}
