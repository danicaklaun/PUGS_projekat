using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TravelPlanner.Shared.Models;

namespace TravelService.Data;

public class TravelDbContext : DbContext
{
    public TravelDbContext(DbContextOptions<TravelDbContext> options)
    : base(options)
    {
    }

    public DbSet<Trip> Trips { get; set; }

    public DbSet<Destination> Destinations { get; set; }

    public DbSet<Activity> Activities { get; set; }

    public DbSet<Expense> Expenses { get; set; }

    public DbSet<ChecklistItem> ChecklistItems { get; set; }
}