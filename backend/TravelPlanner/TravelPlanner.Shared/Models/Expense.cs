using System.ComponentModel.DataAnnotations;

namespace TravelPlanner.Shared.Models;

public class Expense
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public DateTime Date { get; set; }

    public string Category { get; set; } = string.Empty;

    public Guid TripId { get; set; }

    public Trip Trip { get; set; } = null!;
}