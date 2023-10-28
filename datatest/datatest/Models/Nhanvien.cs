using System;
using System.Collections.Generic;

namespace datatest.Models;

public partial class Nhanvien
{
    public string Manv { get; set; } = null!;

    public string? Hoten { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? Gioitinh { get; set; }

    public decimal? Hsluong { get; set; }

    public string? Trinhdo { get; set; }

    public string Madv { get; set; } = null!;

    public string Macv { get; set; } = null!;

    public virtual Chucvu MacvNavigation { get; set; } = null!;

    public virtual Donvi MadvNavigation { get; set; } = null!;
}
