using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public class PgDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CustomerEmail> CustomerEmails { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<CustomerPhone> CustomerPhones { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<QuotationItem> QuotationItems { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        private readonly IConfiguration Configuration;

        public PgDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseNpgsql("Host=localhost;Database=solutionx;Username=postgres;Password=@Dmin1234");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UseCollation("Thai_CI_AS");

            builder.Entity<User>().HasKey(k => new { k.UserId });
            builder.Entity<User>().Property(p => p.UserId).ValueGeneratedOnAdd();
            builder.Entity<User>().Property(p => p.IsActive).HasDefaultValue(true);
            builder.Entity<User>().Property(p => p.CreatedDate).HasDefaultValue(DateTime.UtcNow.Date);
            builder.Entity<User>().Property(p => p.ModifiedDate).HasDefaultValue(DateTime.UtcNow.Date);

            builder.Entity<Customer>().HasKey(k => new { k.CustomerId });
            builder.Entity<Customer>().Property(p => p.CustomerId).ValueGeneratedOnAdd();
            builder.Entity<Customer>().Property(p => p.IsActive).HasDefaultValue(true);
            builder.Entity<Customer>().Property(p => p.CreatedDate).HasDefaultValue(DateTime.UtcNow.Date);
            builder.Entity<Customer>().Property(p => p.ModifiedDate).HasDefaultValue(DateTime.UtcNow.Date);

            builder.Entity<CustomerAddress>().HasKey(k => new { k.CustomerAddressId });
            builder.Entity<CustomerAddress>().Property(p => p.CustomerAddressId).ValueGeneratedOnAdd();

            builder.Entity<Address>().HasKey(k => new { k.AddressId });
            builder.Entity<Address>().Property(p => p.AddressId).ValueGeneratedOnAdd();
            builder.Entity<Address>().Property(p => p.IsActive).HasDefaultValue(true);
            builder.Entity<Address>().Property(p => p.CreatedDate).HasDefaultValue(DateTime.UtcNow.Date);
            builder.Entity<Address>().Property(p => p.ModifiedDate).HasDefaultValue(DateTime.UtcNow.Date);

            builder.Entity<CustomerEmail>().HasKey(k => new { k.CustomerEmailId });
            builder.Entity<CustomerEmail>().Property(p => p.CustomerEmailId).ValueGeneratedOnAdd();

            builder.Entity<Email>().HasKey(k => new { k.EmailId });
            builder.Entity<Email>().Property(p => p.EmailId).ValueGeneratedOnAdd();
            builder.Entity<Email>().Property(p => p.IsActive).HasDefaultValue(true);

            builder.Entity<CustomerPhone>().HasKey(k => new { k.CustomerPhoneId });
            builder.Entity<CustomerPhone>().Property(p => p.CustomerPhoneId).ValueGeneratedOnAdd();

            builder.Entity<Phone>().HasKey(k => new { k.PhoneId });
            builder.Entity<Phone>().Property(p => p.PhoneId).ValueGeneratedOnAdd();
            builder.Entity<Phone>().Property(p => p.IsActive).HasDefaultValue(true);

            builder.Entity<Product>().HasKey(k => new { k.ProductId });
            builder.Entity<Product>().Property(p => p.ProductId).ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.IsActive).HasDefaultValue(true);
            builder.Entity<Product>().Property(p => p.CreatedDate).HasDefaultValue(DateTime.UtcNow.Date);
            builder.Entity<Product>().Property(p => p.ModifiedDate).HasDefaultValue(DateTime.UtcNow.Date);

            builder.Entity<Quotation>().HasKey(k => new { k.QuotationId });
            builder.Entity<Quotation>().Property(p => p.QuotationId).ValueGeneratedOnAdd();
            builder.Entity<Quotation>().Property(p => p.IsActive).HasDefaultValue(true);
            builder.Entity<Quotation>().Property(p => p.CreatedDate).HasDefaultValue(DateTime.UtcNow.Date);
            builder.Entity<Quotation>().Property(p => p.ModifiedDate).HasDefaultValue(DateTime.UtcNow.Date);

            builder.Entity<QuotationItem>().HasKey(k => new { k.QuotationItemId });
            builder.Entity<QuotationItem>().Property(p => p.QuotationItemId).ValueGeneratedOnAdd();

            builder.Entity<PurchaseOrder>().HasKey(k => new { k.OrderId });
            builder.Entity<PurchaseOrder>().Property(p => p.OrderId).ValueGeneratedOnAdd();
            builder.Entity<PurchaseOrder>().Property(p => p.IsActive).HasDefaultValue(true);
            builder.Entity<PurchaseOrder>().Property(p => p.CreatedDate).HasDefaultValue(DateTime.UtcNow.Date);
            builder.Entity<PurchaseOrder>().Property(p => p.ModifiedDate).HasDefaultValue(DateTime.UtcNow.Date);

            builder.Entity<OrderItem>().HasKey(k => new { k.OrderItemId });
            builder.Entity<OrderItem>().Property(p => p.OrderItemId).ValueGeneratedOnAdd();

            builder.Entity<Blog>().HasKey(k => new { k.BlogId });
            builder.Entity<Blog>().Property(p => p.BlogId).ValueGeneratedOnAdd();

            builder.Entity<Post>().HasKey(k => new { k.PostId });
            builder.Entity<Post>().Property(p => p.PostId).ValueGeneratedOnAdd();


            builder.Entity<User>().ToTable("tbl_Users");
            builder.Entity<Customer>().ToTable("tbl_Customers");
            builder.Entity<CustomerAddress>().ToTable("tbl_CustomerAddress");
            builder.Entity<Address>().ToTable("tbl_Address");
            builder.Entity<CustomerEmail>().ToTable("tbl_CustomerEmail");
            builder.Entity<Email>().ToTable("tbl_Email");
            builder.Entity<CustomerPhone>().ToTable("tbl_CustomerPhone");
            builder.Entity<Phone>().ToTable("tbl_Phone");
            builder.Entity<Product>().ToTable("tbl_Product");
            builder.Entity<Quotation>().ToTable("tbl_Quotation");
            builder.Entity<QuotationItem>().ToTable("tbl_QuotationItem");
            builder.Entity<PurchaseOrder>().ToTable("tbl_PurchaseOrder");
            builder.Entity<OrderItem>().ToTable("tbl_OrderItem");
            builder.Entity<Blog>().ToTable("tbl_Blog");
            builder.Entity<Post>().ToTable("tbl_Post");
        }
    }

    // public class User
    // {
    //     public int UserId { get; set; }
    //     public string UserName { get; set; }
    //     public string Password { get; set; }
    //     public bool IsActive { get; set; }
    //     public string CreatedByIp { get; set; }
    //     public string CreatedBy { get; set; }
    //     public DateTime CreatedDate { get; set; }
    //     public string ModifiedBy { get; set; }
    //     public DateTime ModifiedDate { get; set; }
    // }
}