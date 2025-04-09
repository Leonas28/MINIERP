using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class CtlColonia
{
    public int Id { get; set; }

    public int? IdMunicipios { get; set; }

    public int? IdTipoColonia { get; set; }

    public string? NombreColonia { get; set; }

    public string? Zona { get; set; }

    public string? CodigoPostal { get; set; }
}
