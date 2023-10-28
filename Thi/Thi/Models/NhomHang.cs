using System;
using System.Collections.Generic;

namespace Thi.Models;

public partial class NhomHang
{
    public int Manhomhang { get; set; }

    public string? Tennhomhang { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; } = new List<SanPham>();
}
