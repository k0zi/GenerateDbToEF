using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Database.EfCore.Models;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<A> As { get; set; }

    public virtual DbSet<B> Bs { get; set; }

    public virtual DbSet<C> Cs { get; set; }

    public virtual DbSet<D> Ds { get; set; }

    public virtual DbSet<E> Es { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=Database;Integrated Security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<A>(entity =>
        {
            entity.ToTable("A");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<B>(entity =>
        {
            entity.ToTable("B");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<C>(entity =>
        {
            entity.ToTable("C");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<D>(entity =>
        {
            entity.ToTable("D");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<E>(entity =>
        {
            entity.ToTable("E");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
