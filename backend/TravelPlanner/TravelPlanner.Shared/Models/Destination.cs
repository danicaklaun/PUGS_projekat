using System.ComponentModel.DataAnnotations;

namespace TravelPlanner.Shared.Models;

public class Destination
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public DateTime ArrivalDate { get; set; }

    public DateTime DepartureDate { get; set; }

    public Guid TripId { get; set; }

    public Trip Trip { get; set; } = null!;
}