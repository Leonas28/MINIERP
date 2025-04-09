using System;
using System.Collections.Generic;

namespace Mini_ERP_API.Models;

public partial class PedidoVenta
{
    public string IdPedidoVentas { get; set; } = null!;

    public string? IdClasesPedido { get; set; }

    public string? IdOrganizacionVentas { get; set; }

    public string? IdCanales { get; set; }

    public string? IdCliente { get; set; }

    public string? IdIncoterms { get; set; }

    public DateTime? FechaHoraPedido { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public TimeSpan? HoraEntrega { get; set; }

    public string? IdCondicionesPago { get; set; }

    public string? Moneda { get; set; }

    public string? Estatus { get; set; }

    public bool? Bloqueo { get; set; }

    public string? PedidoCliente { get; set; }

    public string? IdInterlocutor { get; set; }

    public string? IdViasDePago { get; set; }

    public int? IdDireccionEntrega { get; set; }

    public string? UsuarioCreacion { get; set; }

    public string? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public TimeSpan? HoraEliminacion { get; set; }

    public string? Metodo { get; set; }
}
