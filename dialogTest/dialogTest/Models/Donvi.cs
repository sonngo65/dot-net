using System;
using System.Collections.Generic;

namespace dialogTest.Models;

public partial class Donvi
{
    public string Madv { get; set; } = null!;

    public string? Tendv { get; set; }

    public string? Dienthoai { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; } = new List<Nhanvien>();
}
