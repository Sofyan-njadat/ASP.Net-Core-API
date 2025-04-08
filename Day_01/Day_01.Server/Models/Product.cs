using System;
using System.Collections.Generic;

namespace Day_01.Server.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
