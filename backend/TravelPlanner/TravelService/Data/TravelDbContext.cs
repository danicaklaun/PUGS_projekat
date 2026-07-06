using Microsoft.EntityFrameworkCore;
using TravelPlanner.Shared.Models;

namespace TravelService.Data;

public class TravelDbContext : DbContext
{
    public TravelDbContext(DbContextOptions<TravelDbContext> options)
        : base(options)
    {
    }

    public DbSet<Trip> Trips => Set<Trip>();

    public DbSet<Destination> Destinations => Set<Destination>();

    public DbSet<Activity> Activities => Set<Activity>();

    public DbSet<Expense> Expenses => Set<Expense>();

    public DbSet<ChecklistItem> ChecklistItems => Set<ChecklistItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Trip>()
    .Property(t => t.Budget)
    .HasPrecision(18, 2);

        modelBuilder.Entity<Expense>()
            .Property(e => e.Amount)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Activity>()
            .Property(a => a.EstimatedCost)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Trip>()
            .HasMany(t => t.Destinations)
            .WithOne(d => d.Trip)
            .HasForeignKey(d => d.TripId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Trip>()
            .HasMany(t => t.Activities)
            .WithOne(a => a.Trip)
            .HasForeignKey(a => a.TripId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Trip>()
            .HasMany(t => t.Expenses)
            .WithOne(e => e.Trip)
            .HasForeignKey(e => e.TripId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Trip>()
            .HasMany(t => t.ChecklistItems)
            .WithOne(c => c.Trip)
            .HasForeignKey(c => c.TripId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}