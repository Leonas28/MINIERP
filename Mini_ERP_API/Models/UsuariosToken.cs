using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class UsuariosToken
{
    public int IdUsuario { get; set; }

    public string Token { get; set; } = null!;
}
