using System;
using System.Collections.Generic;

namespace BlazorMarket.Models;

public partial class Factura
{
    public int NumeroFactura { get; set; }

    public string Ruc { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();
}
