using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class ObjetosEnUso
{
    public string? Objeto { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdTipoObjeto { get; set; }
}
