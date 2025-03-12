using System;
using System.Collections.Generic;

namespace PersonHandle2.Models;

public partial class Person
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public int? Age { get; set; }
}
