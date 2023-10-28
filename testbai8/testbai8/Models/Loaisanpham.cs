using System;
using System.Collections.Generic;

namespace testbai8.Models;

public partial class Loaisanpham
{
    public string Maloai { get; set; } = null!;

    public string? Tenloai { get; set; }

    public virtual ICollection<Sanpham> Sanphams { get; } = new List<Sanpham>();
}
