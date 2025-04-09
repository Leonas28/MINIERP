using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class PedidoCabecera
{
    public int IdPedido { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdDireccion { get; set; }

    public string? Estatus { get; set; }
}
