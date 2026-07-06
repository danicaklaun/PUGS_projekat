using System.ComponentModel.DataAnnotations;

namespace TravelPlanner.Shared.Models;

public class Trip
{
    public Guid Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal Budget { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    public ICollection<Destination> Destinations { get; set; } = new List<Destination>();

    public ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public ICollection<Expense> Expenses { get; set; } = new List<Expense>();

    public ICollection<ChecklistItem> ChecklistItems { get; set; } = new List<ChecklistItem>();
}