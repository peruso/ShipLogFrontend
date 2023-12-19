using Microsoft.EntityFrameworkCore;
using Ship_Review.Models;

namespace Ship_Review.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ShipInfo> ShipInfos { get; set; }
        //public DbSet<Owner> Owners { get; set; }
        //public DbSet<Manager> Managers { get; set; }
        //public DbSet<CurrentVoyage> CurrentVoyages { get; set; }
        public DbSet<ShipEvaluation> ShipEvaluations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //shipinfo to owner relationship is many to one
            //modelBuilder.Entity<ShipInfo>()
            //    .HasOne<Owner>(s => s.Owner)
            //    .WithMany(g => g.ShipInfos)
            //    .HasForeignKey(s => s.OwnerId);
            //shipinfo to manager relationship is many to one
            //modelBuilder.Entity<ShipInfo>()
            //    .HasOne<Manager>(s => s.Manager)
            //    .WithMany(g => g.ShipInfos)
            //    .HasForeignKey(s => s.ManagerId);
            //shipinfo to currentvoyage relationship is one to many
            //modelBuilder.Entity<ShipInfo>()
            //    .HasMany<CurrentVoyage>(s => s.CurrentVoyages)
            //    .WithOne(g => g.ShipInfo)
            //    .HasForeignKey(s => s.ShipInfoId);
            //shipinfo to shipevaluation relationship is one to many
            modelBuilder.Entity<ShipInfo>()
                .HasMany<ShipEvaluation>(s => s.ShipEvaluations)
                .WithOne(g => g.ShipInfo)
                .HasForeignKey(g => g.Imo)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }

}

