using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14_Assignmnt.Models
{
    public partial class ToyCompanyDbContext : DbContext
    {
        public ToyCompanyDbContext()
        {
        }

        public ToyCompanyDbContext(DbContextOptions<ToyCompanyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ToyPlants> ToyPlants { get; set; }
        public virtual DbSet<ToyTypes> ToyTypes { get; set; }
        public virtual DbSet<Toys> Toys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=.\\sqlexpress;database=ToyCompanyDb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.HasIndex(e => e.CustomerId);

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.FirstName).HasColumnName("firstName");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.Property(e => e.LastName).HasColumnName("lastName");

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.HasIndex(e => e.OrderId);

                entity.HasIndex(e => e.ToyId);

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ToyId).HasColumnName("toyId");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Toy)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ToyId);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.HasIndex(e => e.AddressId);

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AddressId);
            });

            modelBuilder.Entity<ToyPlants>(entity =>
            {
                entity.HasKey(e => e.PlantId);

                entity.HasIndex(e => e.ToyTypeId)
                    .IsUnique();

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.Property(e => e.PlantCity).HasColumnName("plantCity");

                entity.Property(e => e.PlantName).HasColumnName("plantName");

                entity.Property(e => e.ToyTypeId).HasColumnName("toyTypeId");

                entity.HasOne(d => d.ToyType)
                    .WithOne(p => p.ToyPlants)
                    .HasForeignKey<ToyPlants>(d => d.ToyTypeId);
            });

            modelBuilder.Entity<ToyTypes>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.Property(e => e.TypeName).HasColumnName("typeName");
            });

            modelBuilder.Entity<Toys>(entity =>
            {
                entity.HasKey(e => e.ToyId);

                entity.HasIndex(e => e.ToyPlantId);

                entity.Property(e => e.ToyId).HasColumnName("toyId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.Property(e => e.ToyName).HasColumnName("toyName");

                entity.Property(e => e.ToyPlantId).HasColumnName("toyPlantId");

                entity.Property(e => e.ToyPrice).HasColumnName("toyPrice");

                entity.HasOne(d => d.ToyPlant)
                    .WithMany(p => p.Toys)
                    .HasForeignKey(d => d.ToyPlantId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
