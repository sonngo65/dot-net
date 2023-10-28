using System;
using System.Collections.Generic;

namespace QuanlyBanhang.Models;

public partial class Nhomhang
{
    public int Manhomhang { get; set; }

    public string? Tennhomhang { get; set; }

    public virtual ICollection<Sanpham> Sanphams { get; } = new List<Sanpham>();
}
