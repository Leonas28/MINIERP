using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class CtlMunicipio
{
    public int Id { get; set; }

    public int? IdEstados { get; set; }

    public string? NombreMunicipio { get; set; }
}
