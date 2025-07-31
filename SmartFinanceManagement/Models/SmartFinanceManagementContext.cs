using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SmartFinanceManagement.Models;

public partial class SmartFinanceManagementContext : DbContext
{
    public SmartFinanceManagementContext()
    {
    }

    public SmartFinanceManagementContext(DbContextOptions<SmartFinanceManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-III283OD;Database=SmartFinanceManagement; Integrated Security=False; Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("User_Id");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Contact_Number");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Email_Id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("First_Name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("Is_Active");
            entity.Property(e => e.IsDelete)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("Is_Delete");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Last_Name");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedOn).HasColumnName("Updated_On");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("User_name");
            entity.Property(e => e.UserType)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("User_Type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
