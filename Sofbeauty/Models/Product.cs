using System;
using System.Collections.Generic;

namespace Sofbeauty.Models;

public partial class Product
{
    public int ProductsId { get; set; }

    public string ProductsName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Type { get; set; }

    public decimal Price { get; set; }

    public string? Img { get; set; }

    public int Stock { get; set; }
}
