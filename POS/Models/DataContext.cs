using Microsoft.EntityFrameworkCore;

namespace POS.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions
        <DataContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Role> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity => {
                entity.HasKey(k => k.RoleId);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
