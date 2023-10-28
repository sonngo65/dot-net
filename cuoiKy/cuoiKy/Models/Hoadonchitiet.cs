using System;
using System.Collections.Generic;

namespace cuoiKy.Models;

public partial class Hoadonchitiet
{
    public string Mahd { get; set; } = null!;

    public string Masp { get; set; } = null!;

    public DateTime? Ngayban { get; set; }

    public int? Soluongmua { get; set; }

    public virtual Sanpham MaspNavigation { get; set; } = null!;
}
