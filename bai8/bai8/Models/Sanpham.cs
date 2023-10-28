using System;
using System.Collections.Generic;

namespace bai8.Models;

public partial class Sanpham
{
    public string Masp { get; set; } = null!;

    public string? Tensp { get; set; }

    public string? Maloai { get; set; }

    public int? Soluong { get; set; }

    public decimal? Dongia { get; set; }

    public virtual Loaisanpham? MaloaiNavigation { get; set; }
}
