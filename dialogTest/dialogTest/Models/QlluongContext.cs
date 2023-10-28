using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dialogTest.Models;

public partial class QlluongContext : DbContext
{
    public QlluongContext()
    {
    }

    public QlluongContext(DbContextOptions<QlluongContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Donvi> Donvis { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=qlluong;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.Macv).HasName("PK__chucvu__7A21F848175C6B01");

            entity.ToTable("chucvu");

            entity.Property(e => e.Macv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("macv");
            entity.Property(e => e.Phucap).HasColumnName("phucap");
            entity.Property(e => e.Tencv)
                .HasMaxLength(20)
                .HasColumnName("tencv");
        });

        modelBuilder.Entity<Donvi>(entity =>
        {
            entity.HasKey(e => e.Madv).HasName("PK__donvi__7A21E029751FDF0C");

            entity.ToTable("donvi");

            entity.Property(e => e.Madv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("madv");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dienthoai");
            entity.Property(e => e.Tendv)
                .HasMaxLength(20)
                .HasColumnName("tendv");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("PK__nhanvien__7A21B37D4C099845");

            entity.ToTable("nhanvien");

            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("manv");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(8)
                .HasColumnName("gioitinh");
            entity.Property(e => e.Hoten)
                .HasMaxLength(20)
                .HasColumnName("hoten");
            entity.Property(e => e.Hsluong)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("hsluong");
            entity.Property(e => e.Macv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("macv");
            entity.Property(e => e.Madv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("madv");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngaysinh");
            entity.Property(e => e.Trinhdo)
                .HasMaxLength(20)
                .HasColumnName("trinhdo");

            entity.HasOne(d => d.MacvNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Macv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_madv_nv");

            entity.HasOne(d => d.MadvNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Madv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_nhanvien");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
