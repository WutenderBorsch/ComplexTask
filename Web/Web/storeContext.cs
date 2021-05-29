using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Web
{
    public partial class storeContext : DbContext
    {
        public storeContext()
        {
        }

        public storeContext(DbContextOptions<storeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AdminMain> AdminMains { get; set; }
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<DeliveryType> DeliveryTypes { get; set; }
        public virtual DbSet<Master> Masters { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product1> Product1s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=store;Username=postgres;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fio).HasColumnName("fio");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");
            });

            modelBuilder.Entity<AdminMain>(entity =>
            {
                entity.ToTable("AdminMain");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EMail).HasColumnName("e-mail");

                entity.Property(e => e.Fio).HasColumnName("FIO");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");
            });


            modelBuilder.Entity<Basket>(entity =>
            {
                entity.ToTable("Basket ");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IdClient).HasColumnName("ID_Client");

                entity.Property(e => e.IdOrder).HasColumnName("ID_Order");

                entity.Property(e => e.IdProduct).HasColumnName("ID_Product");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Baskets)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientBasket");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany(p => p.Baskets)
                    .HasForeignKey(d => d.IdOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderBasket");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Baskets)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductBasket");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Categoryname)
                    .IsRequired()
                    .HasColumnName("categoryname");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DateOfBirth).HasColumnType("timestamp with time zone");

                entity.Property(e => e.DateOfReg).HasColumnType("timestamp with time zone");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("e-mail");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("char");

                entity.Property(e => e.Surname).IsRequired();
            });

            modelBuilder.Entity<DeliveryType>(entity =>
            {
                entity.ToTable("DeliveryType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Master>(entity =>
            {
                entity.ToTable("master");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateOdBirth).HasColumnType("timestamp with time zone");

                entity.Property(e => e.DateOfReg).HasColumnType("timestamp with time zone");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("e-mail");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Nickname).HasColumnName("nickname");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Surname).IsRequired();
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.DateTime).HasColumnType("timestamp with time zone");

                entity.Property(e => e.IdAdmin).HasColumnName("ID_Admin");

                entity.Property(e => e.IdMaster).HasColumnName("ID_Master");

                entity.HasOne(d => d.IdAdminNavigation)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.IdAdmin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdminMessage");

                entity.HasOne(d => d.IdMasterNavigation)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.IdMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MasterMessage");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.CostOrder).HasColumnName("Cost_order");

                entity.Property(e => e.Date).HasColumnType("timestamp with time zone");

                entity.Property(e => e.IdClient).HasColumnName("ID_Client");

                entity.Property(e => e.IdDeliveryType).HasColumnName("ID_DeliveryType");

                entity.Property(e => e.Status).IsRequired();

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderClient");

                entity.HasOne(d => d.IdDeliveryTypeNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdDeliveryType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDelivery");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.IdMaster).HasColumnName("id_master");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Category");

                entity.HasOne(d => d.IdMasterNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdMaster)
                    .HasConstraintName("FK_IDMaster_Product");
            });

            modelBuilder.Entity<Product1>(entity =>
            {
                entity.ToTable("product1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.IdMaster).HasColumnName("id_master");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Product1s)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK_Category1");

                entity.HasOne(d => d.IdMasterNavigation)
                    .WithMany(p => p.Product1s)
                    .HasForeignKey(d => d.IdMaster)
                    .HasConstraintName("FK_IDMaster_Product1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
