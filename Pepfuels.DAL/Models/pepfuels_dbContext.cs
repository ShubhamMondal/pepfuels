using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class pepfuels_dbContext : DbContext
    {
        public pepfuels_dbContext()
        {
        }

        public pepfuels_dbContext(DbContextOptions<pepfuels_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Configure> Configures { get; set; }
        public virtual DbSet<Container> Containers { get; set; }
        public virtual DbSet<ContainerHistory> ContainerHistories { get; set; }
        public virtual DbSet<ContainerItem> ContainerItems { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<FinancialYear> FinancialYears { get; set; }
        public virtual DbSet<Fuel> Fuels { get; set; }
        public virtual DbSet<ItemOrder> ItemOrders { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Supervisor> Supervisors { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=pepfuels_db", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.18-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("cities");

                entity.HasIndex(e => e.CountryId, "country_id");

                entity.HasIndex(e => e.StateId, "state_id");

                entity.Property(e => e.CityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("city_id");

                entity.Property(e => e.CountryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("country_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("short_name");

                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cities_ibfk_1");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cities_ibfk_2");
            });

            modelBuilder.Entity<Configure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("configure");

                entity.Property(e => e.GoogleLocationApiKey)
                    .HasMaxLength(150)
                    .HasColumnName("google_location_api_key");

                entity.Property(e => e.MetaDescription)
                    .HasMaxLength(400)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeywords)
                    .HasMaxLength(400)
                    .HasColumnName("meta_keywords");

                entity.Property(e => e.SecurityAmount)
                    .HasPrecision(18, 2)
                    .HasColumnName("security_amount");
            });

            modelBuilder.Entity<Container>(entity =>
            {
                entity.ToTable("containers");

                entity.HasIndex(e => e.CityId, "containers_ibfk_4");

                entity.HasIndex(e => e.CountryId, "country_id");

                entity.HasIndex(e => e.FinancialYearId, "financial_year_id");

                entity.HasIndex(e => e.StateId, "state_id");

                entity.Property(e => e.ContainerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("container_id");

                entity.Property(e => e.CityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("city_id");

                entity.Property(e => e.ContainerAddress)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("container_address");

                entity.Property(e => e.ContainerPincode)
                    .HasColumnType("int(11)")
                    .HasColumnName("container_pincode");

                entity.Property(e => e.CountryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("country_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.EmergencyNo)
                    .HasMaxLength(20)
                    .HasColumnName("emergency_no");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("int(11)")
                    .HasColumnName("financial_year_id");

                entity.Property(e => e.InstalledOn)
                    .HasColumnType("datetime")
                    .HasColumnName("installed_on");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(40)
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(40)
                    .HasColumnName("longitude");

                entity.Property(e => e.ModelNo)
                    .HasMaxLength(50)
                    .HasColumnName("model_no");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.OccupiedLitres)
                    .HasPrecision(18, 2)
                    .HasColumnName("occupied_litres");

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_id");

                entity.Property(e => e.StatusCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("status_code");

                entity.Property(e => e.SupervisorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("supervisor_id");

                entity.Property(e => e.TotalCapacity)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_capacity");

                entity.Property(e => e.TotalLitres)
                    .HasPrecision(18, 2)
                    .HasColumnName("total_litres");

                entity.Property(e => e.UnoccupiedLitres)
                    .HasPrecision(18, 2)
                    .HasColumnName("unoccupied_litres");

                entity.Property(e => e.UnusedCapacity)
                    .HasColumnType("int(11)")
                    .HasColumnName("unused_capacity");

                entity.Property(e => e.UsedCapacity)
                    .HasColumnType("int(11)")
                    .HasColumnName("used_capacity");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Containers)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("containers_ibfk_4");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Containers)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("containers_ibfk_2");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.Containers)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("containers_ibfk_1");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Containers)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("containers_ibfk_3");
            });

            modelBuilder.Entity<ContainerHistory>(entity =>
            {
                entity.ToTable("container_history");

                entity.HasIndex(e => e.ContainerId, "container_id");

                entity.HasIndex(e => e.ContainerItemId, "container_item_id");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.HasIndex(e => e.SupervisorId, "supervisor_id");

                entity.Property(e => e.ContainerHistoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("container_history_id");

                entity.Property(e => e.ContainerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("container_id");

                entity.Property(e => e.ContainerItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("container_item_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(300)
                    .HasColumnName("remarks");

                entity.Property(e => e.SupervisorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("supervisor_id");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.ContainerHistories)
                    .HasForeignKey(d => d.ContainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("container_history_ibfk_1");

                entity.HasOne(d => d.ContainerItem)
                    .WithMany(p => p.ContainerHistories)
                    .HasForeignKey(d => d.ContainerItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("container_history_ibfk_2");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ContainerHistories)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("container_history_ibfk_3");

                entity.HasOne(d => d.Supervisor)
                    .WithMany(p => p.ContainerHistories)
                    .HasForeignKey(d => d.SupervisorId)
                    .HasConstraintName("container_history_ibfk_4");
            });

            modelBuilder.Entity<ContainerItem>(entity =>
            {
                entity.ToTable("container_items");

                entity.HasIndex(e => e.ContainerId, "container_items_ibfk_1");

                entity.HasIndex(e => e.FinancialYearId, "container_items_ibfk_2");

                entity.Property(e => e.ContainerItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("container_item_id");

                entity.Property(e => e.ApiUrl)
                    .HasMaxLength(200)
                    .HasColumnName("api_url");

                entity.Property(e => e.ContainerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("container_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.EmbeddedCode)
                    .HasMaxLength(150)
                    .HasColumnName("embedded_code");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("int(11)")
                    .HasColumnName("financial_year_id");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.LitreOcccupied)
                    .HasColumnType("int(11)")
                    .HasColumnName("litre_occcupied");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.QrScanGuid)
                    .HasMaxLength(150)
                    .HasColumnName("qr_scan_guid");

                entity.Property(e => e.SerialNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("serial_no");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.ContainerItems)
                    .HasForeignKey(d => d.ContainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("container_items_ibfk_1");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.ContainerItems)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("container_items_ibfk_2");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("countries");

                entity.Property(e => e.CountryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("country_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("currency_code");

                entity.Property(e => e.FlagUrl)
                    .HasMaxLength(120)
                    .HasColumnName("flag_url");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.IsdCode)
                    .HasMaxLength(10)
                    .HasColumnName("isd_code");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("name");

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("region_code");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(10)
                    .HasColumnName("short_name");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.HasIndex(e => e.FinancialYearId, "customers_ibfk_1");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .HasColumnName("contact_no");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.DeviceInfo)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("device_info");

                entity.Property(e => e.EmaiToken)
                    .HasMaxLength(120)
                    .HasColumnName("emai_token");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(60)
                    .HasColumnName("email_address");

                entity.Property(e => e.ExpirationTime)
                    .HasColumnType("datetime")
                    .HasColumnName("expiration_time");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("int(11)")
                    .HasColumnName("financial_year_id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.HasContainer).HasColumnName("has_container");

                entity.Property(e => e.IdentityNo)
                    .HasMaxLength(30)
                    .HasColumnName("identity_no");

                entity.Property(e => e.IdentityType)
                    .HasMaxLength(30)
                    .HasColumnName("identity_type");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ip_address");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.IsEmailVerified).HasColumnName("is_email_verified");

                entity.Property(e => e.IsMobileVerified).HasColumnName("is_mobile_verified");

                entity.Property(e => e.IsSecurityPaid).HasColumnName("is_security_paid");

                entity.Property(e => e.LastLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.LastOrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("last_order_id");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.Otp)
                    .HasColumnType("int(11)")
                    .HasColumnName("otp");

                entity.Property(e => e.SecurityPaidOn)
                    .HasColumnType("datetime")
                    .HasColumnName("security_paid_on");

                entity.Property(e => e.SecurityRefundOn)
                    .HasColumnType("datetime")
                    .HasColumnName("security_refund_on");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customers_ibfk_1");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.ToTable("customer_address");

                entity.HasIndex(e => e.CityId, "city_id");

                entity.HasIndex(e => e.CountryId, "country_id");

                entity.HasIndex(e => e.CustomerId, "customer_address_ibfk_1");

                entity.HasIndex(e => e.StateId, "state_id");

                entity.Property(e => e.CustomerAddressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_address_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .HasColumnName("address2");

                entity.Property(e => e.CityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("city_id");

                entity.Property(e => e.CountryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("country_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.Landmark)
                    .HasMaxLength(20)
                    .HasColumnName("landmark");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .HasColumnName("longitude");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(30)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.Pincode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("pincode");

                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customer_address_ibfk_4");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customer_address_ibfk_2");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customer_address_ibfk_1");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customer_address_ibfk_3");
            });

            modelBuilder.Entity<FinancialYear>(entity =>
            {
                entity.ToTable("financial_years");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("int(11)")
                    .HasColumnName("financial_year_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.CurrentYear)
                    .HasColumnType("int(11)")
                    .HasColumnName("current_year");

                entity.Property(e => e.EndMonth)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("end_month");

                entity.Property(e => e.EndOn)
                    .HasColumnType("datetime")
                    .HasColumnName("end_on");

                entity.Property(e => e.FinancialYearName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("financial_year_name");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.StartMonth)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("start_month");

                entity.Property(e => e.StartOn)
                    .HasColumnType("datetime")
                    .HasColumnName("start_on");
            });

            modelBuilder.Entity<Fuel>(entity =>
            {
                entity.ToTable("fuels");

                entity.HasIndex(e => e.CityId, "city_id");

                entity.HasIndex(e => e.StateId, "state_id");

                entity.Property(e => e.FuelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fuel_id");

                entity.Property(e => e.CityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("city_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.FuelPrice)
                    .HasPrecision(18, 2)
                    .HasColumnName("fuel_price");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(30)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Fuels)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fuels_ibfk_2");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Fuels)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fuels_ibfk_1");
            });

            modelBuilder.Entity<ItemOrder>(entity =>
            {
                entity.ToTable("item_orders");

                entity.HasIndex(e => e.ContainerItemId, "container_item_id");

                entity.HasIndex(e => e.FinancialYearId, "financial_year_id");

                entity.HasIndex(e => e.CustomerId, "item_orders_ibfk_3");

                entity.Property(e => e.ItemOrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_order_id");

                entity.Property(e => e.ContainerItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("container_item_id");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("currency_code");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DiscountAmount)
                    .HasPrecision(18, 2)
                    .HasColumnName("discount_amount");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("int(11)")
                    .HasColumnName("financial_year_id");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.IsPaid).HasColumnName("is_paid");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.NetAmount)
                    .HasPrecision(18, 2)
                    .HasColumnName("net_amount");

                entity.Property(e => e.OrderAmount)
                    .HasPrecision(18, 2)
                    .HasColumnName("order_amount");

                entity.Property(e => e.OrderCode)
                    .IsRequired()
                    .HasMaxLength(120)
                    .HasColumnName("order_code");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_date");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("order_status");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("payment_type");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasColumnName("remarks");

                entity.Property(e => e.Tax)
                    .HasPrecision(18, 2)
                    .HasColumnName("tax");

                entity.HasOne(d => d.ContainerItem)
                    .WithMany(p => p.ItemOrders)
                    .HasForeignKey(d => d.ContainerItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("item_orders_ibfk_1");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ItemOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("item_orders_ibfk_3");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.ItemOrders)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("item_orders_ibfk_2");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.RoleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("role_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("states");

                entity.HasIndex(e => e.CountryId, "country_id");

                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_id");

                entity.Property(e => e.CountryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("country_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("name");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(10)
                    .HasColumnName("short_name");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("states_ibfk_1");
            });

            modelBuilder.Entity<Supervisor>(entity =>
            {
                entity.ToTable("supervisors");

                entity.HasIndex(e => e.CityId, "city_id");

                entity.HasIndex(e => e.CountryId, "country_id");

                entity.HasIndex(e => e.StateId, "state_id");

                entity.Property(e => e.SupervisorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("supervisor_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .HasColumnName("address2");

                entity.Property(e => e.CityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("city_id");

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("contact_no");

                entity.Property(e => e.CountryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("country_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .HasColumnName("email_address");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("full_name");

                entity.Property(e => e.IdentityNo)
                    .HasMaxLength(30)
                    .HasColumnName("identity_no");

                entity.Property(e => e.IdentityType)
                    .HasMaxLength(20)
                    .HasColumnName("identity_type");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.Landmark)
                    .HasMaxLength(30)
                    .HasColumnName("landmark");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(30)
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(30)
                    .HasColumnName("longitude");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.Pincode)
                    .HasMaxLength(10)
                    .HasColumnName("pincode");

                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("status");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Supervisors)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("supervisors_ibfk_3");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Supervisors)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("supervisors_ibfk_1");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Supervisors)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("supervisors_ibfk_2");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.HasIndex(e => e.FinancialYearId, "financial_year_id");

                entity.HasIndex(e => e.ItemOrderId, "item_order_id");

                entity.Property(e => e.TransactionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("transaction_id");

                entity.Property(e => e.Amount)
                    .HasPrecision(18, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("int(11)")
                    .HasColumnName("financial_year_id");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.ItemOrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_order_id");

                entity.Property(e => e.LastBalance)
                    .HasPrecision(18, 2)
                    .HasColumnName("last_balance");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("remarks");

                entity.Property(e => e.TransactionOn)
                    .HasColumnType("datetime")
                    .HasColumnName("transaction_on");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("transaction_type");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("transactions_ibfk_1");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transactions_ibfk_2");

                entity.HasOne(d => d.ItemOrder)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.ItemOrderId)
                    .HasConstraintName("transactions_ibfk_3");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.RoleId, "role_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("contact_no");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(30)
                    .HasColumnName("email_address");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("fullname");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(30)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("role_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("username");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
