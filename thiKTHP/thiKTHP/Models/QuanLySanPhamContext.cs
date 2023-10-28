using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace thiKTHP.Models;

public partial class QuanLySanPhamContext : DbContext
{
    public QuanLySanPhamContext()
    {
    }

    public QuanLySanPhamContext(DbContextOptions<QuanLySanPhamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoaiSanPham");

            entity.Property(e => e.MaLoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenLoai)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C3B8753B5");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp)
                .ValueGeneratedNever()
                .HasColumnName("MaSP");
            entity.Property(e => e.MaLoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenSp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TenSP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
