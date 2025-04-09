using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class OrdenCompraCondicion
{
    public string? IdOrden { get; set; }

    public int? Partida { get; set; }

    public string? IdCondicion { get; set; }

    public decimal? Valor { get; set; }
}
