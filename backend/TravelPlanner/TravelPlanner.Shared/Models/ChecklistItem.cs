using System.ComponentModel.DataAnnotations;

namespace TravelPlanner.Shared.Models;

public class ChecklistItem
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public bool IsCompleted { get; set; }

    public Guid TripId { get; set; }

    public Trip Trip { get; set; } = null!;
}