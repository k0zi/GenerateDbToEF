using System;
using System.Collections.Generic;

namespace Database.EfCore.Models;

public partial class A
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
