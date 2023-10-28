using System;
using System.Collections.Generic;

namespace cuoiKy.Models;

public partial class Sanpham
{
    public string Masp { get; set; } = null!;

    public string? Tensp { get; set; }

    public decimal? Dongia { get; set; }

    public int? Soluongco { get; set; }

    public string? Maloai { get; set; }

    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; } = new List<Hoadonchitiet>();

    public virtual Loaisp? MaloaiNavigation { get; set; }
}
