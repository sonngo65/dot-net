using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cuoiKy.Models;

public partial class QlbanhangContext : DbContext
{
    public QlbanhangContext()
    {
    }

    public QlbanhangContext(DbContextOptions<QlbanhangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; }

    public virtual DbSet<Loaisp> Loaisps { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=qlbanhang;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hoadonchitiet>(entity =>
        {
            entity.HasKey(e => new { e.Mahd, e.Masp }).HasName("pk_hdct");

            entity.ToTable("hoadonchitiet");

            entity.Property(e => e.Mahd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mahd");
            entity.Property(e => e.Masp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("masp");
            entity.Property(e => e.Ngayban)
                .HasColumnType("date")
                .HasColumnName("ngayban");
            entity.Property(e => e.Soluongmua).HasColumnName("soluongmua");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.Masp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_masp");
        });

        modelBuilder.Entity<Loaisp>(entity =>
        {
            entity.HasKey(e => e.Maloai).HasName("PK__loaisp__734B3AEAE1E2F6E0");

            entity.ToTable("loaisp");

            entity.Property(e => e.Maloai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("maloai");
            entity.Property(e => e.Tenloai)
                .HasMaxLength(50)
                .HasColumnName("tenloai");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Masp).HasName("PK__sanpham__7A2176723AE4F8F2");

            entity.ToTable("sanpham");

            entity.Property(e => e.Masp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("masp");
            entity.Property(e => e.Dongia)
                .HasColumnType("money")
                .HasColumnName("dongia");
            entity.Property(e => e.Maloai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("maloai");
            entity.Property(e => e.Soluongco).HasColumnName("soluongco");
            entity.Property(e => e.Tensp)
                .HasMaxLength(50)
                .HasColumnName("tensp");

            entity.HasOne(d => d.MaloaiNavigation).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.Maloai)
                .HasConstraintName("fk_maloai_sp");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
