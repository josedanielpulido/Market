using System;
using System.Collections.Generic;

namespace BlazorMarket.Models;

public partial class DetalleFactura
{
    public int Id { get; set; }

    public int NumeroFactura { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Factura NumeroFacturaNavigation { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
