using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POS.Models;
using POS_IMS.Models;
using System;
using System.Security.Cryptography;
using System.Text;

namespace POS_IMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<InitialContact> IntialContacts { get; set; }
        public virtual DbSet<Validation> Validations { get; set; }
        public virtual DbSet<ApiKey> Apikeys { get; set; }
        public virtual DbSet<BusinessIdentifier> BusinessIdentifiers { get; set; }
        public virtual DbSet<GPS> GPSs { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Logon> Logons { get; set; }
        public virtual DbSet<Conversation> Conversations { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Blend> Blends { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Origin> Origins { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<BlendIngredient> BlendsIngredients { get; set; }
        public virtual DbSet<IngredientOrigin> IngredientOrigins { get; set; }
        public virtual DbSet<IngredientLocation> GetIngredientLocations { get; set; }
        public virtual DbSet<Quantity> Quantities { get; set; }
        public virtual DbSet<Reflection> Reflections { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<ReflectionAsset> ReflectionAssets { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Postcode> Postcodes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<SupplierAddress> SupplierAddresses { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<NDA> NDAs { get; set; }
        public virtual DbSet<QuantityLocation> QuantityLocations { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SaleBlend> SaleBlends { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderIngredient> OrderIngredients { get; set; }
        public virtual DbSet<OrderIngredient> OrderSuppliers { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<SupplierIngredient> SupplierIngredients { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<BrandAsset> BrandAssets { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ContractService> ContractServices { get; set; }
        public virtual DbSet<Assesmbly> Assesmblies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Config config = new Config();

            modelBuilder.Entity<IdentityRole>().Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = config.AiRoleId,
                    Name = "ai",
                    NormalizedName = "AI",
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "USER",
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Sales",
                    NormalizedName = "SALES",
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                },
                new IdentityRole
                {
                    Id = config.SuperAdminRoleId,
                    Name = "SuperAdmin",
                    NormalizedName = "SUPERADMIN",
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                });

            //Create super admin and system AI.
            var superAdmin = new IdentityUser
            {
                Id = config.SuperAdminIdentityId,
                UserName = "SuperAdmin",
                NormalizedUserName = "SUPERADMIN",
                Email = config.superAdminEmail,
                NormalizedEmail = config.superAdminEmail.ToUpper(),
                EmailConfirmed = true
            };
            var systemAi = new IdentityUser
            {
                Id = config.AiIdentityId,
                UserName = "SystemAI",
                NormalizedUserName = "SYSTEMAL",
                Email = config.AiEmail,
                NormalizedEmail = config.AiEmail.ToUpper(),
                EmailConfirmed = true
            };
            var hasher = new PasswordHasher<IdentityUser>();
            var password1 = hasher.HashPassword(superAdmin, "defaultPassword1"); // default password
            var password2 = hasher.HashPassword(systemAi, "defaultPassword2"); //default password
            superAdmin.PasswordHash = password1;
            systemAi.PasswordHash = password2;

            modelBuilder.Entity<IdentityUser>().HasData(superAdmin,systemAi);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = config.AiRoleId,
                UserId = config.AiIdentityId
            },
            new IdentityUserRole<string>
            {
                RoleId = config.SuperAdminRoleId,
                UserId = config.SuperAdminIdentityId
            }) ;


            base.OnModelCreating(modelBuilder);

        }
    }

}
