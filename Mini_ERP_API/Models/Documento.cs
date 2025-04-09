using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class Documento
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Nombrereal { get; set; }

    public byte[]? Archivo { get; set; }
}
