using System;
using System.Collections.Generic;

namespace CoreApiTask.Server.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public string? CategoryDescription { get; set; }
}
