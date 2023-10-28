using System;
using System.Collections.Generic;

namespace QuanlyBanhang.Models;

public partial class Sanpham
{
    public int Masp { get; set; }

    public string? Tensanpham { get; set; }

    public double? Dongia { get; set; }

    public int? Soluongban { get; set; }

    public double? Tienban { get; set; }

    public int? Manhomhang { get; set; }

    public virtual Nhomhang? ManhomhangNavigation { get; set; }
}
