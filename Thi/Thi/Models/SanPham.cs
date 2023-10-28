using System;
using System.Collections.Generic;

namespace Thi.Models;

public partial class SanPham
{
    public int Masp { get; set; }

    public string? Tensanpham { get; set; }

    public double? Dongia { get; set; }

    public int? Soluongban { get; set; }

    public double? Tienban { get; set; }

    public int? Manhomhang { get; set; }

    public virtual NhomHang? ManhomhangNavigation { get; set; }
}
