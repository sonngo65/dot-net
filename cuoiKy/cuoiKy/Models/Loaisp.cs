using System;
using System.Collections.Generic;

namespace cuoiKy.Models;

public partial class Loaisp
{
    public string Maloai { get; set; } = null!;

    public string? Tenloai { get; set; }

    public virtual ICollection<Sanpham> Sanphams { get; } = new List<Sanpham>();
}
