using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanlyBanhang.Models;

public partial class QlSanPhamContext : DbContext
{
    public QlSanPhamContext()
    {
    }

    public QlSanPhamContext(DbContextOptions<QlSanPhamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Nhomhang> Nhomhangs { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=qlSanPham;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nhomhang>(entity =>
        {
            entity.HasKey(e => e.Manhomhang).HasName("PK__nhomhang__7421FCCE48C7E4AD");

            entity.ToTable("nhomhang");

            entity.Property(e => e.Manhomhang)
                .ValueGeneratedNever()
                .HasColumnName("manhomhang");
            entity.Property(e => e.Tennhomhang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tennhomhang");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Masp).HasName("PK__sanpham__7A2176727CE23D1C");

            entity.ToTable("sanpham");

            entity.Property(e => e.Masp)
                .ValueGeneratedNever()
                .HasColumnName("masp");
            entity.Property(e => e.Dongia).HasColumnName("dongia");
            entity.Property(e => e.Manhomhang).HasColumnName("manhomhang");
            entity.Property(e => e.Soluongban).HasColumnName("soluongban");
            entity.Property(e => e.Tensanpham)
                .HasMaxLength(50)
                .HasColumnName("tensanpham");
            entity.Property(e => e.Tienban).HasColumnName("tienban");

            entity.HasOne(d => d.ManhomhangNavigation).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.Manhomhang)
                .HasConstraintName("fk_mnh");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
