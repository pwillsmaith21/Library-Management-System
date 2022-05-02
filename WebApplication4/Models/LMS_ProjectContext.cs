using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication4.Models
{
    public partial class LMS_ProjectContext : DbContext
    {
        public LMS_ProjectContext()
        {
        }

        public LMS_ProjectContext(DbContextOptions<LMS_ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminT> AdminTs { get; set; }
        public virtual DbSet<AuthorT> AuthorTs { get; set; }
        public virtual DbSet<CreditcardT> CreditcardTs { get; set; }
        public virtual DbSet<ItemT> ItemTs { get; set; }
        public virtual DbSet<ItemholdT> ItemholdTs { get; set; }
        public virtual DbSet<ItemstockT> ItemstockTs { get; set; }
        public virtual DbSet<LibrarianCard> LibrarianCards { get; set; }
        public virtual DbSet<LibrarianT> LibrarianTs { get; set; }
        public virtual DbSet<PublisherT> PublisherTs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserT> UserTs { get; set; }
        
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BQ1O4AU;Initial Catalog=LMS_Project;Integrated Security=True");
            }
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminT>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__ADMIN_T__719FE4E84E8B61D9");

                entity.ToTable("ADMIN_T");

                entity.Property(e => e.AdminId)
                    .ValueGeneratedNever()
                    .HasColumnName("AdminID");

                entity.Property(e => e.AdminAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdminCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdminDob)
                    .HasColumnType("date")
                    .HasColumnName("AdminDOB");

                entity.Property(e => e.AdminEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdminFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdminLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdminPassword)
                    .IsRequired()
                    .HasMaxLength(66)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AdminPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdminSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AdminState)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuthorT>(entity =>
            {
                entity.HasKey(e => e.AuthorId);

                entity.ToTable("AUTHOR_T");

                entity.HasIndex(e => e.AuthorId, "UQ__AUTHOR_T__70DAFC159F24DC93")
                    .IsUnique();

                entity.Property(e => e.AuthorId)
                    .ValueGeneratedNever()
                    .HasColumnName("AuthorID");

                entity.Property(e => e.AuthorFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.AuthorTs)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__AUTHOR_T__ItemID__4316F928");
            });

            modelBuilder.Entity<CreditcardT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CREDITCARD_T");

                entity.Property(e => e.CardAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardCvv).HasColumnName("CardCVV");

                entity.Property(e => e.CardExpDate).HasColumnType("date");

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__CREDITCAR__UserI__47DBAE45");
            });

            modelBuilder.Entity<ItemT>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__ITEM_T__727E83EB6C1B5D75");

                entity.ToTable("ITEM_T");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ItemID");

                entity.Property(e => e.DatePublished).HasColumnType("date");

                entity.Property(e => e.Duration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RentalPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);


                entity.HasOne(d => d.AuthorNavigation)
                    .WithMany(p => p.ItemTs)
                    .HasForeignKey(d => d.Author)
                    .HasConstraintName("FK__ITEM_T__Author__3F466844");

                entity.HasOne(d => d.PublisherNavigation)
                    .WithMany(p => p.ItemTs)
                    .HasForeignKey(d => d.Publisher)
                    .HasConstraintName("FK__ITEM_T__Publishe__403A8C7D");
            });

            modelBuilder.Entity<ItemholdT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ITEMHOLD_T");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ItemHold1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.ItemHold1)
                    .HasConstraintName("FK__ITEMHOLD___ItemH__4AB81AF0");

                entity.HasOne(d => d.ItemHold2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.ItemHold2)
                    .HasConstraintName("FK__ITEMHOLD___ItemH__4BAC3F29");

                entity.HasOne(d => d.ItemHold3Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.ItemHold3)
                    .HasConstraintName("FK__ITEMHOLD___ItemH__4CA06362");

                entity.HasOne(d => d.ItemHold4Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.ItemHold4)
                    .HasConstraintName("FK__ITEMHOLD___ItemH__4D94879B");

                entity.HasOne(d => d.ItemHold5Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.ItemHold5)
                    .HasConstraintName("FK__ITEMHOLD___ItemH__4E88ABD4");
            });

            modelBuilder.Entity<ItemstockT>(entity =>
            {
                entity.HasKey(e => e.ItemNumber);

                entity.ToTable("ITEMSTOCK_T");

                entity.Property(e => e.ItemNumber).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ItemNumberNavigation)
                    .WithOne(p => p.ItemstockT)
                    .HasForeignKey<ItemstockT>(d => d.ItemNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ITEMSTOCK__ItemN__4222D4EF");
            });

            modelBuilder.Entity<LibrarianCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LIBRARIAN_CARD");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.HasOne(d => d.CardNumberNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CardNumber)
                    .HasConstraintName("FK__LIBRARIAN__CardN__5070F446");
            });

            modelBuilder.Entity<LibrarianT>(entity =>
            {
                entity.HasKey(e => e.LibrarianId)
                    .HasName("PK__LIBRARIA__E4D86D9DA77FF6A5");

                entity.ToTable("LIBRARIAN_T");

                entity.Property(e => e.LibrarianId)
                    .ValueGeneratedNever()
                    .HasColumnName("LibrarianID");

                entity.Property(e => e.LibrarianAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LibrarianCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LibrarianDob)
                    .HasColumnType("date")
                    .HasColumnName("LibrarianDOB");

                entity.Property(e => e.LibrarianEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LibrarianFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LibrarianLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LibrarianPassword)
                    .IsRequired()
                    .HasMaxLength(66)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LibrarianPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LibrarianSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LibrarianState)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PublisherT>(entity =>
            {
                entity.HasKey(e => e.PublisherId);

                entity.ToTable("PUBLISHER_T");

                entity.HasIndex(e => e.PublisherId, "UQ__PUBLISHE__4C657E4A548DE844")
                    .IsUnique();

                entity.Property(e => e.PublisherId)
                    .ValueGeneratedNever()
                    .HasColumnName("PublisherID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.PublisherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PublisherTs)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__PUBLISHER__ItemI__440B1D61");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FirstName).HasColumnName("firstName");

                entity.Property(e => e.LastName).HasColumnName("lastName");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Zipcode).HasColumnName("zipcode");
            });

            modelBuilder.Entity<UserT>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__USER_T__1788CCAC92BB7317");

                entity.ToTable("USER_T");

                entity.Property(e => e.UserId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UserID");

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDob)
                    .HasColumnType("date")
                    .HasColumnName("UserDOB");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(66)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserState)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
