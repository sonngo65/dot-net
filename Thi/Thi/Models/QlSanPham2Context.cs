using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Thi.Models;

public partial class QlSanPham2Context : DbContext
{
    public QlSanPham2Context()
    {
    }

    public QlSanPham2Context(DbContextOptions<QlSanPham2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NhomHang> NhomHangs { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=qlSanPham2;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhomHang>(entity =>
        {
            entity.HasKey(e => e.Manhomhang).HasName("PK__NhomHang__7421FCCE46581510");

            entity.ToTable("NhomHang");

            entity.Property(e => e.Manhomhang)
                .ValueGeneratedNever()
                .HasColumnName("manhomhang");
            entity.Property(e => e.Tennhomhang)
                .HasMaxLength(50)
                .HasColumnName("tennhomhang");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Masp).HasName("PK__SanPham__7A217672C7B9AF05");

            entity.ToTable("SanPham");

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

            entity.HasOne(d => d.ManhomhangNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.Manhomhang)
                .HasConstraintName("fk_manhomhang");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
