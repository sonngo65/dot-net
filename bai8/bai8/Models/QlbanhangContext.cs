using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace bai8.Models;

public partial class QlbanhangContext : DbContext
{
    public QlbanhangContext()
    {
    }

    public QlbanhangContext(DbContextOptions<QlbanhangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Loaisanpham> Loaisanphams { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=qlbanhang;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Loaisanpham>(entity =>
        {
            entity.HasKey(e => e.Maloai).HasName("PK__loaisanp__734B3AEA508AFB33");

            entity.ToTable("loaisanpham");

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
            entity
                .HasNoKey()
                .ToTable("sanpham");

            entity.Property(e => e.Dongia)
                .HasColumnType("money")
                .HasColumnName("dongia");
            entity.Property(e => e.Maloai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("maloai");
            entity.Property(e => e.Masp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("masp");
            entity.Property(e => e.Soluong).HasColumnName("soluong");
            entity.Property(e => e.Tensp)
                .HasMaxLength(50)
                .HasColumnName("tensp");

            entity.HasOne(d => d.MaloaiNavigation).WithMany()
                .HasForeignKey(d => d.Maloai)
                .HasConstraintName("fk_maloai");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
