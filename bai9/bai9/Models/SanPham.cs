using System;
using System.Collections.Generic;

namespace bai9.Models;

public partial class SanPham
{
    public int MaSp { get; set; }

    public string? TenSp { get; set; }

    public string? MaLoai { get; set; }

    public double? DonGia { get; set; }

    public int? SoLuong { get; set; }
}
