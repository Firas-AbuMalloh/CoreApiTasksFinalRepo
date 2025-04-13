using System;
using System.Collections.Generic;

namespace CoreApiTask.Server.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public int? CategoryId { get; set; }
}
