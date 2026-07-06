using System.ComponentModel.DataAnnotations;

namespace TravelPlanner.Shared.Models;

public class Activity
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Location { get; set; }

    public string? Description { get; set; }

    public DateTime Date { get; set; }

    public decimal EstimatedCost { get; set; }

    public Guid TripId { get; set; }

    public Trip Trip { get; set; } = null!;
}